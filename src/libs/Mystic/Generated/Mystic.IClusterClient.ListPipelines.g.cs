#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// List Pipelines<br/>
        /// List pipelines deployed to a given cluster
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedClusterDeployedPipelineGet> ListPipelinesAsync(
            string clusterId,
            int? skip = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}