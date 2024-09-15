#nullable enable

namespace Mystic
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Delete Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="nodePoolName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.HTTPValidationError> DeleteNodePoolAsync(
            string clusterId,
            string nodePoolName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}