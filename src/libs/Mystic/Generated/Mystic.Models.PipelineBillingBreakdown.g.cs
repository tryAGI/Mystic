
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineBillingBreakdown" /> class.
        /// </summary>
        /// <param name="billingStart"></param>
        /// <param name="billingEnd"></param>
        /// <param name="usages"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineBillingBreakdown(
            global::System.DateTime billingStart,
            global::System.DateTime billingEnd,
            global::System.Collections.Generic.IList<global::Mystic.BillingCostPerPipeline> usages)
        {
            this.BillingStart = billingStart;
            this.BillingEnd = billingEnd;
            this.Usages = usages ?? throw new global::System.ArgumentNullException(nameof(usages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineBillingBreakdown" /> class.
        /// </summary>
        public PipelineBillingBreakdown()
        {
        }
    }
}