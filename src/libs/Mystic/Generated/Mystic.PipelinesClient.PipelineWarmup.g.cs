
#nullable enable

namespace Mystic
{
    public partial class PipelinesClient
    {
        partial void PreparePipelineWarmupArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineIdOrPointer,
            ref string? pipelineId,
            ref string? pointer,
            global::Mystic.PipelineWarmup request);
        partial void PreparePipelineWarmupRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineIdOrPointer,
            string? pipelineId,
            string? pointer,
            global::Mystic.PipelineWarmup request);
        partial void ProcessPipelineWarmupResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Pipeline Warmup
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PipelineWarmupAsync(
            string pipelineIdOrPointer,
            global::Mystic.PipelineWarmup request,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelineWarmupArguments(
                httpClient: HttpClient,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineIdOrPointer}/warmup",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("pointer", pointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PreparePipelineWarmupRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelineWarmupResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::Mystic.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }

        /// <summary>
        /// Pipeline Warmup
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="minimumNodes"></param>
        /// <param name="duration">
        /// Default Value: 300
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PipelineWarmupAsync(
            string pipelineIdOrPointer,
            int minimumNodes,
            string? pipelineId = default,
            string? pointer = default,
            int? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mystic.PipelineWarmup
            {
                MinimumNodes = minimumNodes,
                Duration = duration,
            };

            await PipelineWarmupAsync(
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}