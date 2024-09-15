#nullable enable

namespace Mystic
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Get By Name<br/>
        /// Retrieve a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mystic.ScalingConfigGet> GetByNameAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}