#nullable enable

namespace Mystic
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Delete<br/>
        /// Delete a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mystic.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}