
#nullable enable

namespace Mystic
{
    public partial class PipelinesClient
    {
        partial void PrepareCloneArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            ref string? pointer,
            ref string? pipelineIdOrPointer,
            global::Mystic.ClonePipeline request);
        partial void PrepareCloneRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            string? pointer,
            string? pipelineIdOrPointer,
            global::Mystic.ClonePipeline request);
        partial void ProcessCloneResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCloneResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Clone
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PipelineGet> CloneAsync(
            string pipelineId,
            global::Mystic.ClonePipeline request,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCloneArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineId}/clone",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pointer", pointer) 
                .AddOptionalParameter("pipeline_id_or_pointer", pipelineIdOrPointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCloneRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCloneResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCloneResponseContent(
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
                global::Mystic.PipelineGet.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cluster"></param>
        /// <param name="accelerators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PipelineGet> CloneAsync(
            string pipelineId,
            global::Mystic.PipelineClusterConfig cluster,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mystic.ClonePipeline
            {
                Cluster = cluster,
                Accelerators = accelerators,
            };

            return await CloneAsync(
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}