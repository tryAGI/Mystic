#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// List Projects<br/>
        /// Get all projects on a user's cloud account
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mystic.ProjectGet>> ListProjectsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}