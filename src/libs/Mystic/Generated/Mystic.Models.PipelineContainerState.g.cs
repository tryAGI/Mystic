
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineContainerState
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mystic.JsonConverters.PipelineStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mystic.PipelineState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_run")]
        public string? CurrentRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineContainerState" /> class.
        /// </summary>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="message"></param>
        /// <param name="currentRun"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineContainerState(
            global::Mystic.PipelineState state,
            string? message,
            string? currentRun)
        {
            this.State = state;
            this.Message = message;
            this.CurrentRun = currentRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineContainerState" /> class.
        /// </summary>
        public PipelineContainerState()
        {
        }
    }
}