using System;
using BluePayPayments.Attributes;

namespace BluePayPayments.Enums
{
    public enum StatusResponse
    {
        [EnumValueAttribute("1")]
        Approved = 1,

        [EnumValueAttribute("0")]
        Decline = 2,
        
        Error = 0
    }
}
