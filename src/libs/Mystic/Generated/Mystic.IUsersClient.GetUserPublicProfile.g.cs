#nullable enable

namespace Mystic
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get User Public Profile<br/>
        /// Retrieve a user's public profile
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.UserPublicGet> GetUserPublicProfileAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}