
#nullable enable

namespace Mystic
{
    public partial class CloudClient
    {
        partial void PrepareAuthAwsV4CloudProviderAwsAuthPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mystic.AWSAuthCreate request);
        partial void PrepareAuthAwsV4CloudProviderAwsAuthPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mystic.AWSAuthCreate request);
        partial void ProcessAuthAwsV4CloudProviderAwsAuthPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAuthAwsV4CloudProviderAwsAuthPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Auth Aws
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.AuthAwsV4CloudProviderAwsAuthPostResponse> AuthAwsV4CloudProviderAwsAuthPostAsync(
            global::Mystic.AWSAuthCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAuthAwsV4CloudProviderAwsAuthPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v4/cloud/provider/aws/auth", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::Mystic.SourceGenerationContext.Default.AWSAuthCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAuthAwsV4CloudProviderAwsAuthPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAuthAwsV4CloudProviderAwsAuthPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAuthAwsV4CloudProviderAwsAuthPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Mystic.SourceGenerationContext.Default.AuthAwsV4CloudProviderAwsAuthPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Auth Aws
        /// </summary>
        /// <param name="roleArn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.AuthAwsV4CloudProviderAwsAuthPostResponse> AuthAwsV4CloudProviderAwsAuthPostAsync(
            string roleArn,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mystic.AWSAuthCreate
            {
                RoleArn = roleArn,
            };

            return await AuthAwsV4CloudProviderAwsAuthPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}