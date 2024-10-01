
#nullable enable

namespace Mystic
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class MysticApi : global::Mystic.IMysticApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://www.mystic.ai";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::Mystic.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Mystic.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens => new TokensClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs => new RunsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PointersClient Pointers => new PointersClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineFamiliesClient PipelineFamilies => new PipelineFamiliesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs => new LogsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public CloudClient Cloud => new CloudClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public CredentialsClient Credentials => new CredentialsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public GCPClient GCP => new GCPClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public AWSClient AWS => new AWSClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public AzureClient Azure => new AzureClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClusterClient Cluster => new ClusterClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResourcesClient Resources => new ResourcesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScalingConfigurationsClient ScalingConfigurations => new ScalingConfigurationsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the MysticApi.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorization"></param>
        public MysticApi(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Mystic.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}