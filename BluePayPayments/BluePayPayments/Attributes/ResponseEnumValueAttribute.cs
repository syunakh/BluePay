using System;
namespace BluePayPayments.Attributes
{
    public class EnumValueAttribute : Attribute
    {
        public string Value { get; }

        public EnumValueAttribute(string value)
        {
            Value = value;
        }
    }
}
