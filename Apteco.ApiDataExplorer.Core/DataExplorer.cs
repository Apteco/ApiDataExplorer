using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataExplorer.ApiClient.Model;
using Apteco.ApiDataExplorer.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiDataExplorer.Core
{
  public class DataExplorer
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    private ILogger<DataExplorer> logger;
    #endregion

    #region public constructor
    public DataExplorer(IApiConnectorFactory connectorFactory, string dataViewName, ILogger<DataExplorer> logger)
    {
      this.dataViewName = dataViewName;
      this.connectorFactory = connectorFactory;
      this.logger = logger;
    }
    #endregion

    #region public methods
    public async Task<bool> TryShowRowsForQuery(SessionDetails sessionDetails, string systemName, string queryFilePath, List<string> variableNames, int topNRows, TextWriter outputWriter)
    {
      QueriesService queriesService = new QueriesService(connectorFactory, dataViewName);
      Query query = await queriesService.GetQueryDefinitionFromFile(systemName, sessionDetails, queryFilePath, TimeSpan.FromMinutes(5));
      if (query == null)
        return false;

      if (query?.Selection?.TableName == null)
        throw new Exception($"The query {queryFilePath} must have at least a selection with a table name");

      FastStatsSystemService fastStatsSystemService = new FastStatsSystemService(connectorFactory, dataViewName);
      Variable referenceVariable = await fastStatsSystemService.GetReferenceVariableForTable(sessionDetails, systemName, query.Selection.TableName);
      if (referenceVariable != null)
        variableNames.Insert(0, referenceVariable.Name);

      List<Column> columns = BuildExportColumns(variableNames);

      ExportsService exportsService = new ExportsService(connectorFactory, dataViewName);
      List<string> rows = await exportsService.ExportData(systemName, sessionDetails, query, columns, topNRows, TimeSpan.FromMinutes(5));
      if (rows == null)
        return false;

      foreach (string row in rows)
      {
        outputWriter.WriteLine(row);
      }

      return true;
    }

    public async Task<bool> TryShowRowForUrn(SessionDetails sessionDetails, string systemName, string referenceVariableName, string urnValue, List<string> variableNames, TextWriter outputWriter)
    {
      FastStatsSystemService fastStatsSystemService = new FastStatsSystemService(connectorFactory, dataViewName);
      Variable referenceVariable = await fastStatsSystemService.GetVariable(sessionDetails, systemName, referenceVariableName);
      if (referenceVariable == null)
        throw new Exception($"The variable {referenceVariableName} wasn't found in the system {systemName}");

      Query query = BuildQueryForUrn(referenceVariable, urnValue);

      variableNames.Insert(0, referenceVariableName);
      List<Column> columns = BuildExportColumns(variableNames);

      ExportsService exportsService = new ExportsService(connectorFactory, dataViewName);
      List<string> rows = await exportsService.ExportData(systemName, sessionDetails, query, columns, 1, TimeSpan.FromMinutes(5));
      if (rows == null)
        return false;

      foreach (string row in rows)
      {
        outputWriter.WriteLine(row);
      }

      return true;
    }
    #endregion

    #region private methods
    private Query BuildQueryForUrn(Variable referenceVariable, string urnValue)
    {
      return new Query(
        new Selection(
          TableName: referenceVariable.TableName,
          RecordSet: new RecordSet(
            Type: RecordSet.TypeEnum.URN,
            KeyVariableName: referenceVariable.Name,
            Values: urnValue)));
    }

    private List<Column> BuildExportColumns(List<string> variableNames)
    {
      return variableNames.Select((n, i) => new Column(
        Id: $"Column_{i}",
        VariableName: n,
        Query: null,
        ColumnHeader: n,
        Detail: Column.DetailEnum.Description)).ToList();
    }
    #endregion
  }
}
