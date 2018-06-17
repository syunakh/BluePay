using System;
using System.ComponentModel;
using BluePayPayments.Attributes;

namespace BluePayPayments.Enums
{
    public enum CVVStatus
    {
        [EnumValueAttribute("_")]
        [Description("Unsupported on this network or transaction type")]
        Unsupported,

        [EnumValueAttribute("M")]
        [Description("CVV2 Match")]
        CVV2Match,

        [EnumValueAttribute("N")]
        [Description("CVV2 did not match")]
        CVV2DidNotMatch,

        [EnumValueAttribute("P")]
        [Description("CVV2 was not processed")]
        CVV2WasNotProcessed,

        [EnumValueAttribute("S")]
        [Description("CVV2 exists but was not input")]
        CVV2ExistsButWasNotInput,

        [EnumValueAttribute("U")]
        [Description("Card issuer does not provide CVV2 service")]
        CardIssuerDoesNotProvideCVV2Service,

        [EnumValueAttribute("X")]
        [Description("No response from association")]
        NoResponseFromAssociation,

        [EnumValueAttribute("Y")]
        [Description("CVV2 Match (Amex only when processed through BluePay Canada)")]
        CVV2MatchAmexOnlyWhenProcessedThroughBluePayCanada
    }
}
