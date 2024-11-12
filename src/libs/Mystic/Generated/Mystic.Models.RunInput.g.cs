
#nullable enable

namespace Mystic
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class RunInput
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mystic.JsonConverters.RunIOTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mystic.RunIOType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public string? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunInput" /> class.
        /// </summary>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="value"></param>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="fileUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunInput(
            global::Mystic.RunIOType type,
            object? value,
            string? fileName,
            string? filePath,
            string? fileUrl)
        {
            this.Type = type;
            this.Value = value;
            this.FileName = fileName;
            this.FilePath = filePath;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunInput" /> class.
        /// </summary>
        public RunInput()
        {
        }
    }
}