#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Create Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateNodePoolAsync(
            string clusterId,
            global::Mystic.NodePoolCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="accelerators"></param>
        /// <param name="spot">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateNodePoolAsync(
            string clusterId,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator> accelerators,
            bool? spot = true,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}