using System.Collections.Generic;
using Apteco.ApiDataExplorer.ApiClient.Api;
using Apteco.ApiDataExplorer.ApiClient.Client;
using Apteco.ApiDataExplorer.ApiClient.Model;

namespace Apteco.ApiDataExplorer.Core.Services
{
  public class ApiConnectorFactory : IApiConnectorFactory
  {
    #region private fields
    private string baseUrl;
    #endregion

    #region public constructor
    public ApiConnectorFactory(string baseUrl)
    {
      this.baseUrl = baseUrl;
    }
    #endregion

    #region public methods
    public ISessionsApi CreateSessionsApi(SessionDetails sessionDetails)
    {
      return new SessionsApi(CreateConfiguration(sessionDetails));
    }

    public IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails)
    {
      return new FastStatsSystemsApi(CreateConfiguration(sessionDetails));
    }

    public IExportsApi CreateExportsApi(SessionDetails sessionDetails)
    {
      return new ExportsApi(CreateConfiguration(sessionDetails));
    }

    public IQueriesApi CreateQueriesApi(SessionDetails sessionDetails)
    {
      return new QueriesApi(CreateConfiguration(sessionDetails));
    }
    #endregion

    #region private methods
    private Configuration CreateConfiguration(SessionDetails sessionDetails)
    {
      Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();
      if (sessionDetails != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
      }

      return new Configuration()
      {
        DefaultHeader = defaultHeaders,
        BasePath = baseUrl
      };
    }
    #endregion
  }
}
