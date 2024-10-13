
#nullable enable

namespace Mystic
{
    public partial class PipelinesClient
    {
        partial void PreparePatchImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            ref string? pointer,
            ref string? pipelineIdOrPointer,
            global::Mystic.BodyPatchImageV4PipelinesPipelineIdImagePatch request);
        partial void PreparePatchImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            string? pointer,
            string? pipelineIdOrPointer,
            global::Mystic.BodyPatchImageV4PipelinesPipelineIdImagePatch request);
        partial void ProcessPatchImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Image<br/>
        /// Update the image avatar of a pipeline. The new image url<br/>
        /// will be available in the response.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.GetDetailedPatch> PatchImageAsync(
            string pipelineId,
            global::Mystic.BodyPatchImageV4PipelinesPipelineIdImagePatch request,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchImageArguments(
                httpClient: _httpClient,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineId}/image",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pointer", pointer) 
                .AddOptionalParameter("pipeline_id_or_pointer", pipelineIdOrPointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{pipelineId}"),
                name: "pipeline_id");
            if (pointer != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{pointer}"),
                    name: "pointer");
            } 
            if (pipelineIdOrPointer != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{pipelineIdOrPointer}"),
                    name: "pipeline_id_or_pointer");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "image_file",
                fileName: request.ImageFilename ?? string.Empty);
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchImageRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPatchImageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchImageResponseContent(
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
                global::Mystic.GetDetailedPatch.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch Image<br/>
        /// Update the image avatar of a pipeline. The new image url<br/>
        /// will be available in the response.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.GetDetailedPatch> PatchImageAsync(
            string pipelineId,
            byte[] imageFile,
            string imageFilename,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mystic.BodyPatchImageV4PipelinesPipelineIdImagePatch
            {
                ImageFile = imageFile,
                ImageFilename = imageFilename,
            };

            return await PatchImageAsync(
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}