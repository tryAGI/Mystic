
#nullable enable

namespace Mystic
{
    public partial class PointersClient
    {
        partial void PreparePointersPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pointer,
            global::Mystic.PointerPatch request);
        partial void PreparePointersPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pointer,
            global::Mystic.PointerPatch request);
        partial void ProcessPointersPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPointersPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Pointers Patch<br/>
        /// Update a pipeline pointer instance.
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PointerGet> PointersPatchAsync(
            string pointer,
            global::Mystic.PointerPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePointersPatchArguments(
                httpClient: _httpClient,
                pointer: ref pointer,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pointers/{pointer}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePointersPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pointer: pointer,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPointersPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPointersPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Mystic.PointerGet), JsonSerializerContext) as global::Mystic.PointerGet ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Pointers Patch<br/>
        /// Update a pipeline pointer instance.
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="locked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PointerGet> PointersPatchAsync(
            string pointer,
            string? pointerOrPipelineId = default,
            bool? locked = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mystic.PointerPatch
            {
                PointerOrPipelineId = pointerOrPipelineId,
                Locked = locked,
            };

            return await PointersPatchAsync(
                pointer: pointer,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}