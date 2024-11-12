#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Create Cluster
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateClusterAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}