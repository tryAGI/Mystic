#nullable enable

namespace Mystic
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Patch<br/>
        /// Update selected fields of an API Bearer token for an authenticated user.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.TokenGet> PatchAsync(
            string tokenId,
            global::Mystic.TokenPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch<br/>
        /// Update selected fields of an API Bearer token for an authenticated user.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="name"></param>
        /// <param name="isEnabled"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.TokenGet> PatchAsync(
            string tokenId,
            string? name = default,
            bool isEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}