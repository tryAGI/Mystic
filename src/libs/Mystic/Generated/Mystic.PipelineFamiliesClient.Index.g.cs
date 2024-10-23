
#nullable enable

namespace Mystic
{
    public partial class PipelineFamiliesClient
    {
        partial void PrepareIndexArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref string? teamId,
            ref global::Mystic.AllOf<global::Mystic.OrderBy?>? orderBy,
            ref string? search,
            ref bool? includeAllRun,
            ref int? skip,
            ref int? limit);
        partial void PrepareIndexRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            string? teamId,
            global::Mystic.AllOf<global::Mystic.OrderBy?>? orderBy,
            string? search,
            bool? includeAllRun,
            int? skip,
            int? limit);
        partial void ProcessIndexResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIndexResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Index<br/>
        /// List pipeline families.<br/>
        /// Depending on parameters this can mean all public families, or a user/team's<br/>
        /// specific families.<br/>
        /// Can also be ordered and filtered based on family name.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="orderBy">
        /// Default Value: popular
        /// </param>
        /// <param name="search"></param>
        /// <param name="includeAllRun">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PaginatedPipelineFamilyGet> IndexAsync(
            string? userId = default,
            string? teamId = default,
            global::Mystic.AllOf<global::Mystic.OrderBy?>? orderBy = default,
            string? search = default,
            bool? includeAllRun = false,
            int? skip = 0,
            int? limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIndexArguments(
                httpClient: HttpClient,
                userId: ref userId,
                teamId: ref teamId,
                orderBy: ref orderBy,
                search: ref search,
                includeAllRun: ref includeAllRun,
                skip: ref skip,
                limit: ref limit);

            var __pathBuilder = new PathBuilder(
                path: "/v4/pipeline-families",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("user_id", userId) 
                .AddOptionalParameter("team_id", teamId) 
                .AddOptionalParameter("order_by", orderBy?.ToString() ?? string.Empty) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("include_all_run", includeAllRun?.ToString()) 
                .AddOptionalParameter("skip", skip?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
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
            PrepareIndexRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                userId: userId,
                teamId: teamId,
                orderBy: orderBy,
                search: search,
                includeAllRun: includeAllRun,
                skip: skip,
                limit: limit);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIndexResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessIndexResponseContent(
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
                global::Mystic.PaginatedPipelineFamilyGet.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}