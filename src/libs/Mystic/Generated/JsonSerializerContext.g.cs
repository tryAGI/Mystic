
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mystic
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Mystic.JsonConverters.AcceleratorJsonConverter),
            typeof(global::Mystic.JsonConverters.AcceleratorNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.AccountTierJsonConverter),
            typeof(global::Mystic.JsonConverters.AccountTierNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.RunIOTypeJsonConverter),
            typeof(global::Mystic.JsonConverters.RunIOTypeNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.ContainerRunErrorTypeJsonConverter),
            typeof(global::Mystic.JsonConverters.ContainerRunErrorTypeNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.RunStateJsonConverter),
            typeof(global::Mystic.JsonConverters.RunStateNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.DurationUnitJsonConverter),
            typeof(global::Mystic.JsonConverters.DurationUnitNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.PipelineStateJsonConverter),
            typeof(global::Mystic.JsonConverters.PipelineStateNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.OrderByJsonConverter),
            typeof(global::Mystic.JsonConverters.OrderByNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.ScalingConfigTypeJsonConverter),
            typeof(global::Mystic.JsonConverters.ScalingConfigTypeNullableJsonConverter),
            typeof(global::Mystic.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::Mystic.JsonConverters.AllOfJsonConverterFactory1),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mystic.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}