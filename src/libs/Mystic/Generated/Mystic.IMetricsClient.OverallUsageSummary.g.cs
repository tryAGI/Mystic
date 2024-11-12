#nullable enable

namespace Mystic
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Overall Usage Summary
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.OverallUsageSummary> OverallUsageSummaryAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            string? pipelineId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}