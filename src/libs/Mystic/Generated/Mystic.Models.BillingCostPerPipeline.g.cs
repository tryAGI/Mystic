
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class BillingCostPerPipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_compute_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalComputeTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_estimate")]
        public double? CostEstimate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_run_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FirstRunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastRunAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCostPerPipeline" /> class.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pipelineName"></param>
        /// <param name="runCount"></param>
        /// <param name="totalComputeTimeSeconds"></param>
        /// <param name="costEstimate"></param>
        /// <param name="firstRunAt"></param>
        /// <param name="lastRunAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BillingCostPerPipeline(
            string pipelineId,
            string pipelineName,
            int runCount,
            int totalComputeTimeSeconds,
            global::System.DateTime firstRunAt,
            global::System.DateTime lastRunAt,
            double? costEstimate)
        {
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.PipelineName = pipelineName ?? throw new global::System.ArgumentNullException(nameof(pipelineName));
            this.RunCount = runCount;
            this.TotalComputeTimeSeconds = totalComputeTimeSeconds;
            this.FirstRunAt = firstRunAt;
            this.LastRunAt = lastRunAt;
            this.CostEstimate = costEstimate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCostPerPipeline" /> class.
        /// </summary>
        public BillingCostPerPipeline()
        {
        }
    }
}