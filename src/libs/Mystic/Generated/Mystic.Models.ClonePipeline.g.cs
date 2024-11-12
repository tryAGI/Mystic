
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ClonePipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mystic.PipelineClusterConfig Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        public global::System.Collections.Generic.IList<global::Mystic.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePipeline" /> class.
        /// </summary>
        /// <param name="cluster"></param>
        /// <param name="accelerators"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClonePipeline(
            global::Mystic.PipelineClusterConfig cluster,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators)
        {
            this.Cluster = cluster ?? throw new global::System.ArgumentNullException(nameof(cluster));
            this.Accelerators = accelerators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePipeline" /> class.
        /// </summary>
        public ClonePipeline()
        {
        }
    }
}