using System;

namespace BluePayPayments
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ParamNameAttribute : Attribute
    {
        public string Name { get; set; }

        public ParamNameAttribute(string name)
        {
            Name = name;
        }
    }
}
