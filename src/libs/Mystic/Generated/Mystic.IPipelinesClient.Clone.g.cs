#nullable enable

namespace Mystic
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Clone
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PipelineGet> CloneAsync(
            string pipelineId,
            global::Mystic.ClonePipeline request,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cluster"></param>
        /// <param name="accelerators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PipelineGet> CloneAsync(
            string pipelineId,
            global::Mystic.PipelineClusterConfig cluster,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}