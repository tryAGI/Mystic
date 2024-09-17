#nullable enable

namespace Mystic
{
    public partial interface IPointersClient
    {
        /// <summary>
        /// Pointers Patch<br/>
        /// Update a pipeline pointer instance.
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PointerGet> PointersPatchAsync(
            string pointer,
            global::Mystic.PointerPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Pointers Patch<br/>
        /// Update a pipeline pointer instance.
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="locked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PointerGet> PointersPatchAsync(
            string pointer,
            string? pointerOrPipelineId = default,
            bool? locked = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}