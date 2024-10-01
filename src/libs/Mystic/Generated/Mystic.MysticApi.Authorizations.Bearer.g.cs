
#nullable enable

namespace Mystic
{
    public sealed partial class MysticApi
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Mystic.EndPointAuthorization
            {
                Name = "Bearer",
                Value = apiKey,
            };
        }
    }
}