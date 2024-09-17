#nullable enable

namespace Mystic
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get Pipeline Startup Logs<br/>
        /// Get the logs for pipeline starting up
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.GetPipelineStartupLogsV4LogsPipelineStartupPipelineIdOrPointerGetResponse> GetPipelineStartupLogsAsync(
            string pipelineIdOrPointer,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}