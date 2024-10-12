#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGcpServiceAccountAsync(
            global::Mystic.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="serviceAccountFile"></param>
        /// <param name="serviceAccountFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGcpServiceAccountAsync(
            byte[] serviceAccountFile,
            string serviceAccountFilename,
            string? credentialId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}