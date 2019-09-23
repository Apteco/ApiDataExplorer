using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataExplorer.ApiClient.Api;
using Apteco.ApiDataExplorer.ApiClient.Model;

namespace Apteco.ApiDataExplorer.Core.Services
{
  public class ExportsService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public ExportsService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<List<string>> ExportData(string systemName, SessionDetails sessionDetails, Query baseQuery, List<Column> columns, int numberOfRowsToBrowse, TimeSpan timeout)
    {
      if (baseQuery?.Selection?.TableName == null)
        throw new ArgumentException("The specified baseQuery must have at least a selection with a table name in order for it to be a valid query", nameof(baseQuery));

      IExportsApi exportsApi = connectorFactory.CreateExportsApi(sessionDetails);

      Export export = new Export(
        BaseQuery: baseQuery,
        ResolveTableName: baseQuery.Selection.TableName,
        MaximumNumberOfRowsToBrowse: numberOfRowsToBrowse,
        ReturnBrowseRows: true,
        Columns: columns,
        Limits: null,
        OutputFormat: null,
        PathToExportTo: null);

      ExportResult exportResult = await exportsApi.ExportsPerformExportSynchronouslyAsync(dataViewName, systemName,export, (int)timeout.TotalSeconds, true);

      List<string> data = new List<string>();

      if (exportResult?.Export?.Columns != null)
        data.Add(String.Join("\t", exportResult.Export.Columns.Select(c => c.ColumnHeader)));

      if (exportResult?.Rows != null)
      {
        foreach (Row row in exportResult.Rows)
          data.Add(row.Descriptions);
      }

      return data;
    }
    #endregion
  }
}
