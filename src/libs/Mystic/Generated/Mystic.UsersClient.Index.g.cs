
#nullable enable

namespace Mystic
{
    public partial class UsersClient
    {
        partial void PrepareIndexArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? skip,
            ref int? limit,
            ref string? orderBy);
        partial void PrepareIndexRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? skip,
            int? limit,
            string? orderBy);
        partial void ProcessIndexResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIndexResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of invites to all teams.
        /// </summary>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PaginatedTeamInviteGet> IndexAsync(
            int? skip = 0,
            int? limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIndexArguments(
                httpClient: HttpClient,
                skip: ref skip,
                limit: ref limit,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: "/v4/users/team-invites",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("skip", skip?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order_by", orderBy) 
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
                skip: skip,
                limit: limit,
                orderBy: orderBy);

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
                global::Mystic.PaginatedTeamInviteGet.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}