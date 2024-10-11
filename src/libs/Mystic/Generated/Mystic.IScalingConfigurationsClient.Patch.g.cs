#nullable enable

namespace Mystic
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Patch<br/>
        /// Patch a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> PatchAsync(
            string name,
            global::Mystic.ScalingConfigPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch<br/>
        /// Patch a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="args"></param>
        /// <param name="minimumNodes"></param>
        /// <param name="maximumNodes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> PatchAsync(
            string name,
            global::Mystic.ScalingConfigType? type = default,
            object? args = default,
            int? minimumNodes = default,
            int? maximumNodes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}