#nullable enable

namespace Mystic
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Get Accelerator Availability
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.GetAcceleratorAvailabilityV4CloudProviderAwsAcceleratorAvailabilityGetResponse> GetAcceleratorAvailability2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}