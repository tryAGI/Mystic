
#nullable enable

namespace Mystic
{
    public partial class MetricsClient
    {
        partial void PrepareGetPipelinesCostBreakdownArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int billingCycle);
        partial void PrepareGetPipelinesCostBreakdownRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int billingCycle);
        partial void ProcessGetPipelinesCostBreakdownResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPipelinesCostBreakdownResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Pipelines Cost Breakdown<br/>
        /// Retrieve a cost estimate for each pipeline over a billing cycle.<br/>
        /// Defaults to current billing cycle with query parameter billing_cycle = 0.<br/>
        /// For the previous billing cycle, use value billing_cycle = 1, and so on..<br/>
        /// Notes:<br/>
        ///     - Each computed cost is an estimate and may differ slightly from the<br/>
        ///     exact charge (e.g a pipeline whose accelerator has been patched).<br/>
        ///     - GPU low volume premium rates are encompassed in each cost estimate.<br/>
        ///     - Some pipelines are not included: those running on your own cloud (BYOC)<br/>
        ///     and externally hosted ones (e.g. black-forest-labs/flux-pro).
        /// </summary>
        /// <param name="billingCycle">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PipelineBillingBreakdown> GetPipelinesCostBreakdownAsync(
            int billingCycle = 0,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetPipelinesCostBreakdownArguments(
                httpClient: _httpClient,
                billingCycle: ref billingCycle);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/metrics/pipelines-cost?billing_cycle={billingCycle}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetPipelinesCostBreakdownRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                billingCycle: billingCycle);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetPipelinesCostBreakdownResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetPipelinesCostBreakdownResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Mystic.SourceGenerationContext.Default.PipelineBillingBreakdown) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}