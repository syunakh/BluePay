using System;
using System.ComponentModel;
using BluePayPayments.Attributes;

namespace BluePayPayments.Enums
{
    public enum AVSStatus
    {
        [ResponseEnumValue("_")]
        Empty,

        [ResponseEnumValue("A")]
        [Description("Partial match - Street Address matches, ZIP Code does not")]
        PartialMatchStreetAddressMatchZIPCodedoesnt,

        [ResponseEnumValue("B")]
        [Description("International street address match, postal code not verified due to incompatible formats")]
        InternationalStreetAddressMatchPostalCodeNotVerified,

        [ResponseEnumValue("C")]
        [Description("International street address and postal code not verified due to incompatible formats")]
        InternationalStreetAddressAndPostalCodeNotVerified,

        [ResponseEnumValue("D")]
        [Description("International street address and postal code match")]
        InternationalStreetAddressAndPostalCodeMatch,

        [ResponseEnumValue("E")]
        [Description("Not a mail or phone order")]
        NotAMailOrPhoneOrder,

        [ResponseEnumValue("F")]
        [Description("Address and Postal Code match (UK only)")]
        AddressAndPostalCodeMatchUKOnly,

        [ResponseEnumValue("G")]
        [Description("Service Not supported, non-US Issuer does not participate")]
        ServiceNotSupportedNonUSIssuer,

        [ResponseEnumValue("I")]
        [Description("Address information not verified for international transaction")]
        AddressInformationNotVerifiedForInternationalTransaction,

        [ResponseEnumValue("M")]
        [Description("Address and Postal Code match")]
        AddressAndPostalCodeMatch,

        [ResponseEnumValue("N")]
        [Description("No match - No Address or ZIP Code match")]
        NoMatchNoAddressOrZIPCodeMatch,

        [ResponseEnumValue("P")]
        [Description("International postal code match, street address not verified due to incompatible format")]
        InternationalPostalCodeMatchStreetAddressNotVerified,

        [ResponseEnumValue("Q")]
        [Description("Bill to address did not pass edit checks/Card Association can't verify the authentication of an address")]
        BillToAddressDidNotPassEditChecksCardAssociationCantVerifyTheAuthenticationOfAnAddress,

        [ResponseEnumValue("R")]
        [Description("Retry - Issuer system unavailable, retry later")]
        RetryIssuerSystemUnavailable,

        [ResponseEnumValue("S")]
        [Description("Service not supported")]
        ServiceNotSupported,

        [ResponseEnumValue("W")]
        [Description("Partial match - ZIP Code matches, Street Address does not")]
        PartialMatchZIPCodeMatchesStreetAddressDoesNot,

        [ResponseEnumValue("U")]
        [Description("Unavailable - Address information is unavailable for that account number, or the card issuer does not support")]
        UnavailableAddressInformationIsUnavailableForThatAccountNumberOrTheCardIssuerDoesNotSupport,

        [ResponseEnumValue("X")]
        [Description("Exact match, 9 digit zip - Street Address, and 9 digit ZIP Code match")]
        ExactMatch9DigitZipStreetAddressAnd9DigitZIPCodeMatch,

        [ResponseEnumValue("Y")]
        [Description("Exact match, 5 digit zip - Street Address, and 5 digit ZIP Code match")]
        ExactMatch5DigitZipStreetAddressAnd5DigitZIPCodeMatch,

        [ResponseEnumValue("Z")]
        [Description("Partial match - 5 digit ZIP Code match only")]
        PartialMatch5DigitZIPCodeMatchOnly,

        [ResponseEnumValue("1")]
        [Description("Cardholder name matches")]
        CardholderNameMatches,

        [ResponseEnumValue("2")]
        [Description("Cardholder name, billing address, and postal code match")]
        CardholderNameBillingAddressAndPostalCodeMatch,

        [ResponseEnumValue("3")]
        [Description("Cardholder name and billing postal code match")]
        CardholderNameAndBillingPostalCodeMatch,

        [ResponseEnumValue("4")]
        [Description("Cardholder name and billing address match")]
        CardholderNameAndBillingAddressMatch,

        [ResponseEnumValue("5")]
        [Description("Cardholder name incorrect, billing address and postal code match")]
        CardholderNameIncorrectBillingAddressAndPostalCodeMatch,

        [ResponseEnumValue("6")]
        [Description("Cardholder name incorrect, billing postal code matches")]
        CardholderNameIncorrectBillingPostalCodeMatches,

        [ResponseEnumValue("7")]
        [Description("Cardholder name incorrect, billing address matches")]
        CardholderNameIncorrectBillingAddressMatches,

        [ResponseEnumValue("8")]
        [Description("Cardholder name, billing address, and postal code are all incorrect")]
        CardholderNameBillingAddressAndPostalCodeAreAllIncorrect
    }
}
