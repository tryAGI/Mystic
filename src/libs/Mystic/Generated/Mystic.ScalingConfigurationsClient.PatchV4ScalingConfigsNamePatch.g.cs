
#nullable enable

namespace Mystic
{
    public partial class ScalingConfigurationsClient
    {
        partial void PreparePatchV4ScalingConfigsNamePatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            global::Mystic.ScalingConfigPatch request);
        partial void PreparePatchV4ScalingConfigsNamePatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            global::Mystic.ScalingConfigPatch request);
        partial void ProcessPatchV4ScalingConfigsNamePatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchV4ScalingConfigsNamePatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch<br/>
        /// Patch a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> PatchV4ScalingConfigsNamePatchAsync(
            string name,
            global::Mystic.ScalingConfigPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchV4ScalingConfigsNamePatchArguments(
                httpClient: _httpClient,
                name: ref name,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/scaling-configs/{name}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::Mystic.SourceGenerationContext.Default.ScalingConfigPatch);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchV4ScalingConfigsNamePatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                name: name,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPatchV4ScalingConfigsNamePatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchV4ScalingConfigsNamePatchResponseContent(
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
        /// Patch<br/>
        /// Patch a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="args"></param>
        /// <param name="minimumNodes"></param>
        /// <param name="maximumNodes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> PatchV4ScalingConfigsNamePatchAsync(
            string name,
            global::Mystic.ScalingConfigType? type = default,
            global::Mystic.ScalingConfigPatchArgs? args = default,
            int minimumNodes = default,
            int maximumNodes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mystic.ScalingConfigPatch
            {
                Type = type,
                Args = args,
                MinimumNodes = minimumNodes,
                MaximumNodes = maximumNodes,
            };

            return await PatchV4ScalingConfigsNamePatchAsync(
                name: name,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}