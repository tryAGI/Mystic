#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Retrieve Cluster<br/>
        /// Retrieve a cluster for a user
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.ClusterGet> RetrieveClusterAsync(
            string clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}