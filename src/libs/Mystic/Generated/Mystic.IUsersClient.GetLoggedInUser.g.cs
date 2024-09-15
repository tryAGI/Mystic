#nullable enable

namespace Mystic
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get Logged In User<br/>
        /// Retrieve the currently logged in user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.UserGet> GetLoggedInUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}