#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Auth Gcp
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AuthGcpAsync(
            string? credentialId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}