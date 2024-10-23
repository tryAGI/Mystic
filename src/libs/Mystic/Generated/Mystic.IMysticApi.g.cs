
#nullable enable

namespace Mystic
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IMysticApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Mystic.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public PointersClient Pointers { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelineFamiliesClient PipelineFamilies { get; }

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// 
        /// </summary>
        public CloudClient Cloud { get; }

        /// <summary>
        /// 
        /// </summary>
        public CredentialsClient Credentials { get; }

        /// <summary>
        /// 
        /// </summary>
        public GCPClient GCP { get; }

        /// <summary>
        /// 
        /// </summary>
        public AWSClient AWS { get; }

        /// <summary>
        /// 
        /// </summary>
        public AzureClient Azure { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClusterClient Cluster { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResourcesClient Resources { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScalingConfigurationsClient ScalingConfigurations { get; }

    }
}