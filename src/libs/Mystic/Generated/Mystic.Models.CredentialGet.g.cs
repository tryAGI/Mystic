
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class CredentialGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AuthError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="authError"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CredentialGet(
            string id,
            string provider,
            bool authError)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.AuthError = authError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialGet" /> class.
        /// </summary>
        public CredentialGet()
        {
        }
    }
}