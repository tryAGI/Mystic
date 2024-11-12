#nullable enable

namespace Mystic
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of pipelines.
        /// </summary>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedPipelineGet> IndexAsync(
            int? skip = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}