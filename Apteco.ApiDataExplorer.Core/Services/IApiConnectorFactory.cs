using Apteco.ApiDataExplorer.ApiClient.Api;
using Apteco.ApiDataExplorer.ApiClient.Model;

namespace Apteco.ApiDataExplorer.Core.Services
{
  public interface IApiConnectorFactory
  {
    #region public methods
    ISessionsApi CreateSessionsApi(SessionDetails sessionDetails);
    IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails);
    IExportsApi CreateExportsApi(SessionDetails sessionDetails);
    IQueriesApi CreateQueriesApi(SessionDetails sessionDetails);
    #endregion
  }
}
