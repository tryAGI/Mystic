#nullable enable

namespace Mystic
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Detailed<br/>
        /// Retrieve a more detailed version of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.AppSchemasRunGetDetailed> RetrieveDetailedAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}