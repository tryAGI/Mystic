
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
            int? skip = 0,
            int? limit = 20,
            string? orderBy = default,
            bool? @public = default,
            global::Mystic.AllOf<global::Mystic.Accelerator?>? hardware = default,
            string? clusterId = default,
            string? nodePool = default,
            string? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListPipelinesByFamilyArguments(
                httpClient: _httpClient,
                pipelineFamilyName: ref pipelineFamilyName,
                skip: ref skip,
                limit: ref limit,
                orderBy: ref orderBy,
                @public: ref @public,
                hardware: ref hardware,
                clusterId: ref clusterId,
                nodePool: ref nodePool,
                createdAt: ref createdAt);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pipelines/by-family/{pipelineFamilyName}?skip={skip}&limit={limit}&order_by={orderBy}&public={@public}&hardware={hardware}&cluster_id={clusterId}&node_pool={nodePool}&created_at={createdAt}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListPipelinesByFamilyRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineFamilyName: pipelineFamilyName,
                skip: skip,
                limit: limit,
                orderBy: orderBy,
                @public: @public,
                hardware: hardware,
                clusterId: clusterId,
                nodePool: nodePool,
                createdAt: createdAt);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListPipelinesByFamilyResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListPipelinesByFamilyResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Mystic.PaginatedGetMetaAndPointers), JsonSerializerContext) as global::Mystic.PaginatedGetMetaAndPointers ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}