#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// List Clusters<br/>
        /// List all clusters belonging to a user/team
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mystic.ClusterGet>> ListClustersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}