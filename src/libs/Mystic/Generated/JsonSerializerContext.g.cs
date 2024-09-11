
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
            typeof(global::AutoSDK.JsonConverters.AcceleratorJsonConverter),
            typeof(global::AutoSDK.JsonConverters.AcceleratorNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.AccountTierJsonConverter),
            typeof(global::AutoSDK.JsonConverters.AccountTierNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.RunIOTypeJsonConverter),
            typeof(global::AutoSDK.JsonConverters.RunIOTypeNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ContainerRunErrorTypeJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ContainerRunErrorTypeNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.RunStateJsonConverter),
            typeof(global::AutoSDK.JsonConverters.RunStateNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.DurationUnitJsonConverter),
            typeof(global::AutoSDK.JsonConverters.DurationUnitNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.PipelineStateJsonConverter),
            typeof(global::AutoSDK.JsonConverters.PipelineStateNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.OrderByJsonConverter),
            typeof(global::AutoSDK.JsonConverters.OrderByNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ScalingConfigTypeJsonConverter),
            typeof(global::AutoSDK.JsonConverters.ScalingConfigTypeNullableJsonConverter),
            typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::AutoSDK.JsonConverters.AllOfJsonConverterFactory1),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mystic.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}