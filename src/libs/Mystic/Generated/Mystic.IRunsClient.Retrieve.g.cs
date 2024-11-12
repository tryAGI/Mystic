#nullable enable

namespace Mystic
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve the details of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.ClusterRunResult> RetrieveAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}