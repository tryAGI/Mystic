#nullable enable

namespace Mystic
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Used Pipelines<br/>
        /// Retrieve paginated metrics for all pipelines used by a user, optionally<br/>
        /// filtered by 'search'.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedPipelineMetrics> UsedPipelinesAsync(
            string? search = default,
            int? skip = 0,
            int? limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}