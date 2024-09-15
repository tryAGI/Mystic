#nullable enable

namespace Mystic
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Top Pipelines Usage<br/>
        /// Retrieve usage metrics for top 'num_pipelines' (in terms of number of<br/>
        /// runs) for the provided time period.
        /// </summary>
        /// <param name="numPipelines">
        /// Default Value: 20
        /// </param>
        /// <param name="clusterId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="intervalUnit">
        /// An enumeration.
        /// </param>
        /// <param name="intervalValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.TopPipelinesUsageV4MetricsTopPipelinesUsageGetResponse> TopPipelinesUsageAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            global::Mystic.DurationUnit intervalUnit,
            int intervalValue,
            int numPipelines = 20,
            string? clusterId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}