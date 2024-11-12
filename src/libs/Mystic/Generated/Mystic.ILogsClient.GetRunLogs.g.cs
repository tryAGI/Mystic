#nullable enable

namespace Mystic
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get Run Logs<br/>
        /// Get the pipeline logs for a run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRunLogsAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}