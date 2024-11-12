#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// List Credentials<br/>
        /// List all credentials belonging to a user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mystic.CredentialGet>> ListCredentialsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}