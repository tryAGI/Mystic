
#nullable enable

namespace Mystic
{
    public partial class LogsClient
    {
        partial void PrepareGetPipelineStartupLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineIdOrPointer,
            ref string? pipelineId,
            ref string? pointer);
        partial void PrepareGetPipelineStartupLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineIdOrPointer,
            string? pipelineId,
            string? pointer);
        partial void ProcessGetPipelineStartupLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPipelineStartupLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Pipeline Startup Logs<br/>
        /// Get the logs for pipeline starting up
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> GetPipelineStartupLogsAsync(
            string pipelineIdOrPointer,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPipelineStartupLogsArguments(
                httpClient: HttpClient,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                pipelineId: ref pipelineId,
                pointer: ref pointer);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/logs/pipeline-startup/{pipelineIdOrPointer}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("pointer", pointer) 
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
            PrepareGetPipelineStartupLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetPipelineStartupLogsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetPipelineStartupLogsResponseContent(
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

            return __content;
        }
    }
}