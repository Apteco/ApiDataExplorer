/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Apteco.ApiDataExplorer.ApiClient.Client;
using Apteco.ApiDataExplorer.ApiClient.Model;

namespace Apteco.ApiDataExplorer.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICollectionHitsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns details for a given collection hit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>CollectionHitDetail</returns>
        CollectionHitDetail CollectionHitsGetCollectionHit (string dataViewName, int? collectionHitId);

        /// <summary>
        /// Returns details for a given collection hit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>ApiResponse of CollectionHitDetail</returns>
        ApiResponse<CollectionHitDetail> CollectionHitsGetCollectionHitWithHttpInfo (string dataViewName, int? collectionHitId);
        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>PagedResultsCollectionHitSummary</returns>
        PagedResultsCollectionHitSummary CollectionHitsGetCollectionHits (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>ApiResponse of PagedResultsCollectionHitSummary</returns>
        ApiResponse<PagedResultsCollectionHitSummary> CollectionHitsGetCollectionHitsWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns details for a given collection hit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>Task of CollectionHitDetail</returns>
        System.Threading.Tasks.Task<CollectionHitDetail> CollectionHitsGetCollectionHitAsync (string dataViewName, int? collectionHitId);

        /// <summary>
        /// Returns details for a given collection hit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>Task of ApiResponse (CollectionHitDetail)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionHitDetail>> CollectionHitsGetCollectionHitAsyncWithHttpInfo (string dataViewName, int? collectionHitId);
        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of PagedResultsCollectionHitSummary</returns>
        System.Threading.Tasks.Task<PagedResultsCollectionHitSummary> CollectionHitsGetCollectionHitsAsync (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of ApiResponse (PagedResultsCollectionHitSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResultsCollectionHitSummary>> CollectionHitsGetCollectionHitsAsyncWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CollectionHitsApi : ICollectionHitsApi
    {
        private Apteco.ApiDataExplorer.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionHitsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CollectionHitsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.ApiDataExplorer.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionHitsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CollectionHitsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Apteco.ApiDataExplorer.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Apteco.ApiDataExplorer.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns details for a given collection hit 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>CollectionHitDetail</returns>
        public CollectionHitDetail CollectionHitsGetCollectionHit (string dataViewName, int? collectionHitId)
        {
             ApiResponse<CollectionHitDetail> localVarResponse = CollectionHitsGetCollectionHitWithHttpInfo(dataViewName, collectionHitId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns details for a given collection hit 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>ApiResponse of CollectionHitDetail</returns>
        public ApiResponse< CollectionHitDetail > CollectionHitsGetCollectionHitWithHttpInfo (string dataViewName, int? collectionHitId)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling CollectionHitsApi->CollectionHitsGetCollectionHit");
            // verify the required parameter 'collectionHitId' is set
            if (collectionHitId == null)
                throw new ApiException(400, "Missing required parameter 'collectionHitId' when calling CollectionHitsApi->CollectionHitsGetCollectionHit");

            var localVarPath = "./{dataViewName}/CollectionHits/{collectionHitId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (collectionHitId != null) localVarPathParams.Add("collectionHitId", Configuration.ApiClient.ParameterToString(collectionHitId)); // path parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CollectionHitsGetCollectionHit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionHitDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CollectionHitDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionHitDetail)));
        }

        /// <summary>
        /// Returns details for a given collection hit 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>Task of CollectionHitDetail</returns>
        public async System.Threading.Tasks.Task<CollectionHitDetail> CollectionHitsGetCollectionHitAsync (string dataViewName, int? collectionHitId)
        {
             ApiResponse<CollectionHitDetail> localVarResponse = await CollectionHitsGetCollectionHitAsyncWithHttpInfo(dataViewName, collectionHitId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns details for a given collection hit 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="collectionHitId">The id of the hit</param>
        /// <returns>Task of ApiResponse (CollectionHitDetail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CollectionHitDetail>> CollectionHitsGetCollectionHitAsyncWithHttpInfo (string dataViewName, int? collectionHitId)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling CollectionHitsApi->CollectionHitsGetCollectionHit");
            // verify the required parameter 'collectionHitId' is set
            if (collectionHitId == null)
                throw new ApiException(400, "Missing required parameter 'collectionHitId' when calling CollectionHitsApi->CollectionHitsGetCollectionHit");

            var localVarPath = "./{dataViewName}/CollectionHits/{collectionHitId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (collectionHitId != null) localVarPathParams.Add("collectionHitId", Configuration.ApiClient.ParameterToString(collectionHitId)); // path parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CollectionHitsGetCollectionHit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionHitDetail>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CollectionHitDetail) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionHitDetail)));
        }

        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users. 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>PagedResultsCollectionHitSummary</returns>
        public PagedResultsCollectionHitSummary CollectionHitsGetCollectionHits (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
             ApiResponse<PagedResultsCollectionHitSummary> localVarResponse = CollectionHitsGetCollectionHitsWithHttpInfo(dataViewName, filter, orderBy, offset, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users. 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>ApiResponse of PagedResultsCollectionHitSummary</returns>
        public ApiResponse< PagedResultsCollectionHitSummary > CollectionHitsGetCollectionHitsWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling CollectionHitsApi->CollectionHitsGetCollectionHits");

            var localVarPath = "./{dataViewName}/CollectionHits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (filter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "orderBy", orderBy)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CollectionHitsGetCollectionHits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagedResultsCollectionHitSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PagedResultsCollectionHitSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedResultsCollectionHitSummary)));
        }

        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users. 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of PagedResultsCollectionHitSummary</returns>
        public async System.Threading.Tasks.Task<PagedResultsCollectionHitSummary> CollectionHitsGetCollectionHitsAsync (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
             ApiResponse<PagedResultsCollectionHitSummary> localVarResponse = await CollectionHitsGetCollectionHitsAsyncWithHttpInfo(dataViewName, filter, orderBy, offset, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns all the hit information for all collections.  This endpoint is only available for admin users. 
        /// </summary>
        /// <exception cref="Apteco.ApiDataExplorer.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="filter">Filter the list of items using a simple expression language.  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="orderBy">Order the items by a given field (in ascending order unless the field is preceeded by a \&quot;-\&quot; character).  The available list of fields are Username, Timestamp, UserAgentDetails (optional)</param>
        /// <param name="offset">The number of items to skip in the (potentially filtered) result set before returning subsequent items. (optional)</param>
        /// <param name="count">The maximum number of items to show from the (potentially filtered) result set. (optional)</param>
        /// <returns>Task of ApiResponse (PagedResultsCollectionHitSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagedResultsCollectionHitSummary>> CollectionHitsGetCollectionHitsAsyncWithHttpInfo (string dataViewName, string filter = null, string orderBy = null, int? offset = null, int? count = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling CollectionHitsApi->CollectionHitsGetCollectionHits");

            var localVarPath = "./{dataViewName}/CollectionHits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (filter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "orderBy", orderBy)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CollectionHitsGetCollectionHits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagedResultsCollectionHitSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PagedResultsCollectionHitSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedResultsCollectionHitSummary)));
        }

    }
}
