
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineBillingBreakdown
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BillingStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BillingEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mystic.BillingCostPerPipeline> Usages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}