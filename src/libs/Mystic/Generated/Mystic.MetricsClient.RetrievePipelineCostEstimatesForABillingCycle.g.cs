
#nullable enable

namespace Mystic
{
    public partial class MetricsClient
    {
        partial void PrepareRetrievePipelineCostEstimatesForABillingCycleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int billingCycleOffset);
        partial void PrepareRetrievePipelineCostEstimatesForABillingCycleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int billingCycleOffset);
        partial void ProcessRetrievePipelineCostEstimatesForABillingCycleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrievePipelineCostEstimatesForABillingCycleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve pipeline cost estimates for a billing cycle<br/>
        /// Retrieve a cost estimate for each pipeline over a billing cycle.<br/>
        /// Defaults to the current billing cycle with `billing_cycle_offset=0`.<br/>
        /// Notes:<br/>
        ///     - Each computed cost is an estimate and may differ slightly from the exact<br/>
        ///     charge. For instance, if your billing cycle anchor or pipeline accelerator has<br/>
        ///     been updated.<br/>
        ///     - GPU low volume premium rates are encompassed in each cost estimate.<br/>
        ///     - Some pipelines are not included: those running on your own cloud (BYOC) and<br/>
        ///       externally hosted ones (e.g., black-forest-labs/flux-pro).
        /// </summary>
        /// <param name="billingCycleOffset">
        /// The number of months to offset the billing cycle. Defaults to 0 (current cycle). Use 1 for the previous cycle, 2 for two cycles ago, etc.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mystic.PipelineBillingBreakdown> RetrievePipelineCostEstimatesForABillingCycleAsync(
            int billingCycleOffset = 0,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRetrievePipelineCostEstimatesForABillingCycleArguments(
                httpClient: _httpClient,
                billingCycleOffset: ref billingCycleOffset);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/metrics/pipelines-cost?billing_cycle_offset={billingCycleOffset}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRetrievePipelineCostEstimatesForABillingCycleRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                billingCycleOffset: billingCycleOffset);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRetrievePipelineCostEstimatesForABillingCycleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRetrievePipelineCostEstimatesForABillingCycleResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Mystic.PipelineBillingBreakdown), JsonSerializerContext) as global::Mystic.PipelineBillingBreakdown ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}