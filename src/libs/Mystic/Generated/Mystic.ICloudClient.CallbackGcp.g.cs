#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Callback Gcp
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.CallbackGcpV4CloudProviderGcpCallbackGetResponse> CallbackGcpAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}