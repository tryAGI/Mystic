
#nullable enable

namespace Mystic
{
    public partial class MetricsClient
    {
        partial void PrepareOverallUsageSummaryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime start,
            ref global::System.DateTime end,
            ref string? pipelineId);
        partial void PrepareOverallUsageSummaryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime start,
            global::System.DateTime end,
            string? pipelineId);
        partial void ProcessOverallUsageSummaryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOverallUsageSummaryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Overall Usage Summary
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.OverallUsageSummary> OverallUsageSummaryAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            string? pipelineId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOverallUsageSummaryArguments(
                httpClient: _httpClient,
                start: ref start,
                end: ref end,
                pipelineId: ref pipelineId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/metrics/overall-usage-summary?start={start:yyyy-MM-ddTHH:mm:ssZ}&end={end:yyyy-MM-ddTHH:mm:ssZ}&pipeline_id={pipelineId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOverallUsageSummaryRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                start: start,
                end: end,
                pipelineId: pipelineId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOverallUsageSummaryResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOverallUsageSummaryResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Mystic.OverallUsageSummary), JsonSerializerContext) as global::Mystic.OverallUsageSummary ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}