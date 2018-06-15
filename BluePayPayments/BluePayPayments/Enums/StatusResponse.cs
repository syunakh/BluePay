using System;
using BluePayPayments.Attributes;

namespace BluePayPayments.Enums
{
    public enum StatusResponse
    {
        [ResponseEnumValue("1")]
        Approved = 1,

        [ResponseEnumValue("0")]
        Decline = 2,
        
        Error = 0
    }
}
