using System;

namespace BluePayPayments.Extensions
{
    public static class EnumExtensions
    {
        public static T ToEnum<T>(this string value, T defaultValue) where T : struct
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            return Enum.TryParse<T>(value, true, out var result) ? result : defaultValue;
        }

        public static T ToEnum<T>(this int? value, T defaultValue) where T : struct
        {
            if (!value.HasValue)
            {
                return defaultValue;
            }

            return Enum.TryParse<T>(value.ToString(), true, out var result) ? result : defaultValue;
        }

        public static string GetEnumName<T>(this T enumValue) where T : struct, IConvertible
        {
            return Enum.GetName(typeof(T), enumValue);
        }
    }
}
