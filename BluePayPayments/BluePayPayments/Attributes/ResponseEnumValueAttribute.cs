using System;
namespace BluePayPayments.Attributes
{
    public class ResponseEnumValueAttribute: Attribute
    {
        public string Value { get; }

        public ResponseEnumValueAttribute(string value)
        {

        }
    }
}
