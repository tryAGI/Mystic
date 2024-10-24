
#nullable enable

namespace Mystic
{
    public partial class PipelinesClient
    {
        partial void PrepareListPipelinesByFamilyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineFamilyName,
            ref int? skip,
            ref int? limit,
            ref string? orderBy,
            ref bool? @public,
            ref global::Mystic.AllOf<global::Mystic.Accelerator?>? hardware,
            ref string? clusterId,
            ref string? nodePool,
            ref string? createdAt);
        partial void PrepareListPipelinesByFamilyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineFamilyName,
            int? skip,
            int? limit,
            string? orderBy,
            bool? @public,
            global::Mystic.AllOf<global::Mystic.Accelerator?>? hardware,
            string? clusterId,
            string? nodePool,
            string? createdAt);
        partial void ProcessListPipelinesByFamilyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelinesByFamilyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Pipelines By Family<br/>
        /// Retrieve all pipelines for a given pipeline family.<br/>
        /// Include private pipelines if the user owns the family.
        /// </summary>
        /// <param name="pipelineFamilyName"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="public">
        /// Filter by public status
        /// </param>
        /// <param name="hardware">
        /// Filter by hardware/accelerator type
        /// </param>
        /// <param name="clusterId">
        /// Filter by cluster ID
        /// </param>
        /// <param name="nodePool">
        /// Filter by node pool
        /// </param>
        /// <param name="createdAt">
        /// Filter by datetime in the format 'created_at=start:end'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PaginatedGetMetaAndPointers> ListPipelinesByFamilyAsync(
            string pipelineFamilyName,
            int? skip = default,
            int? limit = default,
            string? orderBy = default,
            bool? @public = default,
            global::Mystic.AllOf<global::Mystic.Accelerator?>? hardware = default,
            string? clusterId = default,
            string? nodePool = default,
            string? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListPipelinesByFamilyArguments(
                httpClient: HttpClient,
                pipelineFamilyName: ref pipelineFamilyName,
                skip: ref skip,
                limit: ref limit,
                orderBy: ref orderBy,
                @public: ref @public,
                hardware: ref hardware,
                clusterId: ref clusterId,
                nodePool: ref nodePool,
                createdAt: ref createdAt);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/by-family/{pipelineFamilyName}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("skip", skip?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order_by", orderBy) 
                .AddOptionalParameter("public", @public?.ToString()) 
                .AddOptionalParameter("hardware", hardware?.ToString() ?? string.Empty) 
                .AddOptionalParameter("cluster_id", clusterId) 
                .AddOptionalParameter("node_pool", nodePool) 
                .AddOptionalParameter("created_at", createdAt) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListPipelinesByFamilyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineFamilyName: pipelineFamilyName,
                skip: skip,
                limit: limit,
                orderBy: orderBy,
                @public: @public,
                hardware: hardware,
                clusterId: clusterId,
                nodePool: nodePool,
                createdAt: createdAt);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListPipelinesByFamilyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListPipelinesByFamilyResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Mystic.PaginatedGetMetaAndPointers.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}