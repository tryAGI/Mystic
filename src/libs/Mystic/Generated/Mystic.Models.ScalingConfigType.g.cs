
#nullable enable

namespace Mystic
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ScalingConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Windows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScalingConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScalingConfigType value)
        {
            return value switch
            {
                ScalingConfigType.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScalingConfigType? ToEnum(string value)
        {
            return value switch
            {
                "windows" => ScalingConfigType.Windows,
                _ => null,
            };
        }
    }
}