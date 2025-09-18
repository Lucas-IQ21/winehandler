using System;
using System.ComponentModel;
using System.Linq;

namespace wineHandler.Utils
{
    public static class EnumHelper
    {
        public static string GetDescription<TEnum>(TEnum value) where TEnum : Enum
        {
            var enumType = typeof(TEnum);
            var field = enumType.GetField(value.ToString());

            if (field != null)
            {
                var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                     .Cast<DescriptionAttribute>()
                                     .FirstOrDefault();

                if (attribute != null)
                    return attribute.Description;
            }
            return value.ToString();
        }
    }
}
