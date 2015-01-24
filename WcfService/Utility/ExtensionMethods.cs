using System;
using System.ComponentModel;

namespace WcfService.Utility
{
    public static class ExtensionMethods
    {
        public static string GetEnumDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static int GetValue(this Enum value)
        {
            return Convert.ToInt32(value);
        }
    }
}