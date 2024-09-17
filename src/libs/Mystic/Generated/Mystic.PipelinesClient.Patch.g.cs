
#nullable enable

namespace Mystic
{
    public partial class PipelinesClient
    {
        partial void PreparePatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            ref string? pointer,
            ref string? pipelineIdOrPointer,
            global::Mystic.Patch request);
        partial void PreparePatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            string? pointer,
            string? pipelineIdOrPointer,
            global::Mystic.Patch request);
        partial void ProcessPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch<br/>
        /// Update selected fields on a pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.GetDetailedPatch> PatchAsync(
            string pipelineId,
            global::Mystic.Patch request,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchArguments(
                httpClient: _httpClient,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pipelines/{pipelineId}?pointer={pointer}&pipeline_id_or_pointer={pipelineIdOrPointer}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchRequest(
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
            ProcessPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Mystic.GetDetailedPatch), JsonSerializerContext) as global::Mystic.GetDetailedPatch ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch<br/>
        /// Update selected fields on a pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="public"></param>
        /// <param name="description"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="paperUrl"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="readme"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="accelerators"></param>
        /// <param name="extras"></param>
        /// <param name="scalingConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.GetDetailedPatch> PatchAsync(
            string pipelineId,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            bool? @public = default,
            string? description = default,
            string? websiteUrl = default,
            string? repositoryUrl = default,
            string? paperUrl = default,
            string? licenseUrl = default,
            string? imageUrl = default,
            string? readme = default,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable>? inputVariables = default,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable>? outputVariables = default,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators = default,
            global::Mystic.PatchExtras? extras = default,
            string? scalingConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mystic.Patch
            {
                Public = @public,
                Description = description,
                WebsiteUrl = websiteUrl,
                RepositoryUrl = repositoryUrl,
                PaperUrl = paperUrl,
                LicenseUrl = licenseUrl,
                ImageUrl = imageUrl,
                Readme = readme,
                InputVariables = inputVariables,
                OutputVariables = outputVariables,
                Accelerators = accelerators,
                Extras = extras,
                ScalingConfig = scalingConfig,
            };

            return await PatchAsync(
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}