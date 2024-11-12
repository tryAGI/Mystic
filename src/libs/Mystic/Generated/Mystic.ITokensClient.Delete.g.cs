#nullable enable

namespace Mystic
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Delete<br/>
        /// Delete an API Bearer token for an authenticated user.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}