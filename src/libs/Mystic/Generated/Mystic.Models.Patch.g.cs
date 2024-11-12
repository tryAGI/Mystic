
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class Patch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        public global::System.Collections.Generic.IList<global::Mystic.IOVariable>? InputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variables")]
        public global::System.Collections.Generic.IList<global::Mystic.IOVariable>? OutputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        public global::System.Collections.Generic.IList<global::Mystic.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaling_config")]
        public string? ScalingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Patch" /> class.
        /// </summary>
        /// <param name="public"></param>
        /// <param name="description"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="paperUrl"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="readme"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="accelerators"></param>
        /// <param name="extras"></param>
        /// <param name="scalingConfig"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Patch(
            bool? @public,
            string? description,
            string? websiteUrl,
            string? repositoryUrl,
            string? paperUrl,
            string? licenseUrl,
            string? imageUrl,
            string? readme,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable>? inputVariables,
            global::System.Collections.Generic.IList<global::Mystic.IOVariable>? outputVariables,
            global::System.Collections.Generic.IList<global::Mystic.Accelerator>? accelerators,
            object? extras,
            string? scalingConfig)
        {
            this.Public = @public;
            this.Description = description;
            this.WebsiteUrl = websiteUrl;
            this.RepositoryUrl = repositoryUrl;
            this.PaperUrl = paperUrl;
            this.LicenseUrl = licenseUrl;
            this.ImageUrl = imageUrl;
            this.Readme = readme;
            this.InputVariables = inputVariables;
            this.OutputVariables = outputVariables;
            this.Accelerators = accelerators;
            this.Extras = extras;
            this.ScalingConfig = scalingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patch" /> class.
        /// </summary>
        public Patch()
        {
        }
    }
}