#nullable enable

namespace Mystic
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a new Catalyst API Bearer token for an authenticated user.<br/>
        /// This token will be associated with a team if a team_id is present in the JWT.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.TokenGet> CreateAsync(
            global::Mystic.TokenCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create<br/>
        /// Create a new Catalyst API Bearer token for an authenticated user.<br/>
        /// This token will be associated with a team if a team_id is present in the JWT.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expiresAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.TokenGet> CreateAsync(
            string? name = default,
            global::System.DateTime expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}