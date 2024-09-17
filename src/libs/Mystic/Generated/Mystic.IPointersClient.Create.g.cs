#nullable enable

namespace Mystic
{
    public partial interface IPointersClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a pipeline pointer instance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PointerGet> CreateAsync(
            global::Mystic.PointerCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create<br/>
        /// Create a pipeline pointer instance.
        /// </summary>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="locked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PointerGet> CreateAsync(
            string pointerOrPipelineId,
            string pointer,
            bool? locked = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}