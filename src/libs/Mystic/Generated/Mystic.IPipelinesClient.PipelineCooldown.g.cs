#nullable enable

namespace Mystic
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Pipeline Cooldown
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task PipelineCooldownAsync(
            string pipelineIdOrPointer,
            global::Mystic.PipelineCooldown request,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Pipeline Cooldown
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="duration">
        /// Default Value: 1800
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PipelineCooldownAsync(
            string pipelineIdOrPointer,
            string? pipelineId = default,
            string? pointer = default,
            int? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}