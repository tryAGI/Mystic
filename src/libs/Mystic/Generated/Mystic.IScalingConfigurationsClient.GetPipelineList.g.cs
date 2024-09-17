#nullable enable

namespace Mystic
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Get Pipeline List<br/>
        /// Get a list of pipelines scoped to the user which use a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedGetLean> GetPipelineListAsync(
            string name,
            int? skip = 0,
            int? limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}