using System;
using System.ComponentModel;
using BluePayPayments.Attributes;

namespace BluePayPayments.Enums
{
    public enum CVVStatus
    {
        [ResponseEnumValue("_")]
        [Description("Unsupported on this network or transaction type")]
        Unsupported,

        [ResponseEnumValue("M")]
        [Description("CVV2 Match")]
        CVV2Match,

        [ResponseEnumValue("N")]
        [Description("CVV2 did not match")]
        CVV2DidNotMatch,

        [ResponseEnumValue("P")]
        [Description("CVV2 was not processed")]
        CVV2WasNotProcessed,

        [ResponseEnumValue("S")]
        [Description("CVV2 exists but was not input")]
        CVV2ExistsButWasNotInput,

        [ResponseEnumValue("U")]
        [Description("Card issuer does not provide CVV2 service")]
        CardIssuerDoesNotProvideCVV2Service,

        [ResponseEnumValue("X")]
        [Description("No response from association")]
        NoResponseFromAssociation,

        [ResponseEnumValue("Y")]
        [Description("CVV2 Match (Amex only when processed through BluePay Canada)")]
        CVV2MatchAmexOnlyWhenProcessedThroughBluePayCanada
    }
}
