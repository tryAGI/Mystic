#nullable enable

namespace Mystic
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of invites to all teams.
        /// </summary>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.PaginatedTeamInviteGet> IndexAsync(
            int skip = 0,
            int limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}