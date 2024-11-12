#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Get Accelerator Availability
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAcceleratorAvailability2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}