#nullable enable

namespace Mystic
{
    public partial interface IMetricsClient
    {
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
        global::System.Threading.Tasks.Task<global::Mystic.PipelineBillingBreakdown> RetrievePipelineCostEstimatesForABillingCycleAsync(
            int? billingCycleOffset = 0,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}