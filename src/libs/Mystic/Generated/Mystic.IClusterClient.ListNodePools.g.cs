#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// List Node Pools<br/>
        /// List node pools for a given cluster
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mystic.NodePool>> ListNodePoolsAsync(
            string clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}