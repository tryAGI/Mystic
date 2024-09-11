
#nullable enable

namespace Mystic
{
    public partial class CloudClient
    {
        partial void PrepareAuthGcpV4CloudProviderGcpAuthGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? credentialId);
        partial void PrepareAuthGcpV4CloudProviderGcpAuthGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? credentialId);
        partial void ProcessAuthGcpV4CloudProviderGcpAuthGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAuthGcpV4CloudProviderGcpAuthGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Auth Gcp
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.AuthGcpV4CloudProviderGcpAuthGetResponse> AuthGcpV4CloudProviderGcpAuthGetAsync(
            string? credentialId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAuthGcpV4CloudProviderGcpAuthGetArguments(
                httpClient: _httpClient,
                credentialId: ref credentialId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/cloud/provider/gcp/auth?credential_id={credentialId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAuthGcpV4CloudProviderGcpAuthGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                credentialId: credentialId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAuthGcpV4CloudProviderGcpAuthGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAuthGcpV4CloudProviderGcpAuthGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Mystic.SourceGenerationContext.Default.AuthGcpV4CloudProviderGcpAuthGetResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}