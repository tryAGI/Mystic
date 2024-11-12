#nullable enable

namespace Mystic
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a Catalyst API Bearer token for an authenticated user.
        /// </summary>
        /// <param name="allTeam">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedTokenGet> IndexAsync(
            bool? allTeam = default,
            int? skip = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}