
#nullable enable

namespace Mystic
{
    public partial class ScalingConfigurationsClient
    {
        partial void PrepareCreateV4ScalingConfigsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mystic.ScalingConfigCreate request);
        partial void PrepareCreateV4ScalingConfigsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mystic.ScalingConfigCreate request);
        partial void ProcessCreateV4ScalingConfigsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateV4ScalingConfigsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create<br/>
        /// Create a scaling configuration for pipelines
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> CreateV4ScalingConfigsPostAsync(
            global::Mystic.ScalingConfigCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateV4ScalingConfigsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v4/scaling-configs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::Mystic.SourceGenerationContext.Default.ScalingConfigCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateV4ScalingConfigsPostRequest(
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
            ProcessCreateV4ScalingConfigsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateV4ScalingConfigsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Mystic.SourceGenerationContext.Default.ScalingConfigGet) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create<br/>
        /// Create a scaling configuration for pipelines
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minimumNodes">
        /// Default Value: 0
        /// </param>
        /// <param name="maximumNodes">
        /// Default Value: 100
        /// </param>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="args"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> CreateV4ScalingConfigsPostAsync(
            string name,
            global::Mystic.ScalingConfigCreateArgs args,
            int minimumNodes = 0,
            int maximumNodes = 100,
            global::Mystic.ScalingConfigType type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mystic.ScalingConfigCreate
            {
                Name = name,
                MinimumNodes = minimumNodes,
                MaximumNodes = maximumNodes,
                Type = type,
                Args = args,
            };

            return await CreateV4ScalingConfigsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}