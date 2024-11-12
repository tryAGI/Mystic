#nullable enable

namespace Mystic
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Owned Or Used<br/>
        /// Get a lean list of pipelines that the user/team has either used or owns.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mystic.GetLean>> OwnedOrUsedAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}