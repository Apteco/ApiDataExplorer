using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataExplorer.ApiClient.Model;
using Apteco.ApiDataExplorer.Core;
using Apteco.ApiDataExplorer.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiDataExplorer.Console
{
  class Program
  {
    private static int Main(string[] args)
    {
      if (args == null || args.Length < 1)
      {
        return OutputUsage();
      }

      Task<int> task = Task.Run(() => PerformAction(args));
      task.Wait();
      return task.Result;
    }

    private static async Task<int> PerformAction(string[] args)
    {
      if (args[0].ToLower() == "rows")
      {
        if (args.Length < 8)
          return OutputUsage();

        List<string> variableNames = args.Skip(7).Select(s => s.Trim()).ToList();
        return await OutputRows(args[1], args[2], args[3], args[4], args[5], args[6], variableNames);
      }
      else if (args[0].ToLower() == "urn")
      {
        if (args.Length < 9)
          return OutputUsage();

        List<string> variableNames = args.Skip(8).Select(s => s.Trim()).ToList();
        return await OutputRow(args[1], args[2], args[3], args[4], args[5], args[6], args[7], variableNames);
      }
      else
      {
        return OutputUsage();
      }
    }

    private static int OutputUsage()
    {
      string usageString =
        "Usage: "+ Environment.NewLine +
        "  ApiDataExplorer-Console.exe rows <Orbit API base URL> <DataView name> <username> <password> <system name> <query file path> <variable name 1> [<varable name 2> ...]" + Environment.NewLine +
        " Or" + Environment.NewLine +
        "  ApiDataExplorer-Console.exe urn <Orbit API base URL> <DataView name> <username> <password> <system name> <reference variable name> <urn value> <variable name 1> [<varable name 2> ...]" + Environment.NewLine +
        Environment.NewLine +
        Environment.NewLine +
        "The rows command will output the first 100 rows selected selected by the given query, for each of the variables specified." + Environment.NewLine +
        Environment.NewLine +
        "The urn command will output the a single for for the record with the given value for the given reference variable, for each of the variables specified." + Environment.NewLine;

      System.Console.WriteLine(usageString);
      return 0;
    }

    private static async Task<int> OutputRows(string baseUrl, string dataViewName, string username, string password, string systemName, string queryFilePath, List<string> variableNames)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ILogger<Program> logger = loggingHandler.CreateLogger<Program>();

        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);
        LoginService loginService = new LoginService(connectorFactory, dataViewName);

        SessionDetails sessionDetails = await loginService.Login(username, password);
        if (sessionDetails == null)
        {
          logger.LogError($"Couldn't log in to data view {dataViewName} as user {username}");
          return -1;
        }

        try
        {
          DataExplorer dataExplorer = new DataExplorer(connectorFactory, dataViewName, loggingHandler.CreateLogger<DataExplorer>());
          bool success = await dataExplorer.TryShowRowsForQuery(sessionDetails, systemName, queryFilePath, variableNames, 100, System.Console.Out);
          return success ? 0 : -1;
        }
        finally
        {
          await loginService.Logout(sessionDetails);
        }
      }
    }

    private static async Task<int> OutputRow(string baseUrl, string dataViewName, string username, string password, string systemName, string referenceVariableName, string urnValue, List<string> variableNames)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ILogger<Program> logger = loggingHandler.CreateLogger<Program>();

        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);
        LoginService loginService = new LoginService(connectorFactory, dataViewName);

        SessionDetails sessionDetails = await loginService.Login(username, password);
        if (sessionDetails == null)
        {
          logger.LogError($"Couldn't log in to data view {dataViewName} as user {username}");
          return -1;
        }

        try
        {
          DataExplorer dataExplorer = new DataExplorer(connectorFactory, dataViewName, loggingHandler.CreateLogger<DataExplorer>());
          bool success = await dataExplorer.TryShowRowForUrn(sessionDetails, systemName, referenceVariableName, urnValue, variableNames, System.Console.Out);
          return success ? 0 : -1;
        }
        finally
        {
          await loginService.Logout(sessionDetails);
        }
      }
    }
  }
}
