#nullable enable

namespace Mystic
{
    public partial interface IResourcesClient
    {
        /// <summary>
        /// Set Pod Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task SetPodInfoAsync(
            global::Mystic.ResourcePodInfo request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Pod Info
        /// </summary>
        /// <param name="podName"></param>
        /// <param name="podIp"></param>
        /// <param name="nodeName"></param>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="currentRun"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetPodInfoAsync(
            string podName,
            string podIp,
            string nodeName,
            global::Mystic.PipelineState state,
            string? currentRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}