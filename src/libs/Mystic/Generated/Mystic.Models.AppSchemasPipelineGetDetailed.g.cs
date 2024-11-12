
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class AppSchemasPipelineGetDetailed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mystic.IOVariable> InputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mystic.IOVariable> OutputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        public global::System.Collections.Generic.IList<global::Mystic.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// A lean representation of a cluster when returned from an API call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public global::Mystic.PipelineClusterGetLean? Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaling_config")]
        public string? ScalingConfig { get; set; }

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_state_info")]
        public global::Mystic.PipelineContainerState? FailedStateInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointers")]
        public global::System.Collections.Generic.IList<string>? Pointers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppSchemasPipelineGetDetailed" /> class.
        /// </summary>
        /// <param name="public"></param>
        /// <param name="description"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="paperUrl"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="extras"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="accelerators"></param>
        /// <param name="cluster">
        /// A lean representation of a cluster when returned from an API call
        /// </param>
        /// <param name="scalingConfig"></param>
        /// <param name="failedStateInfo">
        /// Base model for schemas.
        /// </param>
        /// <param name="pointers"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppSchemasPipelineGetDetailed(
            bool @public,
            string name,
            string image,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable> inputVariables,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable> outputVariables,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? websiteUrl,
            string? repositoryUrl,
            string? paperUrl,
            string? licenseUrl,
            string? imageUrl,
            object? extras,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators,
            global::Mystic.PipelineClusterGetLean? cluster,
            string? scalingConfig,
            global::Mystic.PipelineContainerState? failedStateInfo,
            global::System.Collections.Generic.IList<string>? pointers)
        {
            this.Public = @public;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.OutputVariables = outputVariables ?? throw new global::System.ArgumentNullException(nameof(outputVariables));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.WebsiteUrl = websiteUrl;
            this.RepositoryUrl = repositoryUrl;
            this.PaperUrl = paperUrl;
            this.LicenseUrl = licenseUrl;
            this.ImageUrl = imageUrl;
            this.Extras = extras;
            this.Accelerators = accelerators;
            this.Cluster = cluster;
            this.ScalingConfig = scalingConfig;
            this.FailedStateInfo = failedStateInfo;
            this.Pointers = pointers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppSchemasPipelineGetDetailed" /> class.
        /// </summary>
        public AppSchemasPipelineGetDetailed()
        {
        }
    }
}