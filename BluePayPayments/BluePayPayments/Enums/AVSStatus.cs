using System;
using System.ComponentModel;
using BluePayPayments.Attributes;

namespace BluePayPayments.Enums
{
    public enum AVSStatus
    {
        [EnumValueAttribute("_")]
        Empty,

        [EnumValueAttribute("A")]
        [Description("Partial match - Street Address matches, ZIP Code does not")]
        PartialMatchStreetAddressMatchZIPCodedoesnt,

        [EnumValueAttribute("B")]
        [Description("International street address match, postal code not verified due to incompatible formats")]
        InternationalStreetAddressMatchPostalCodeNotVerified,

        [EnumValueAttribute("C")]
        [Description("International street address and postal code not verified due to incompatible formats")]
        InternationalStreetAddressAndPostalCodeNotVerified,

        [EnumValueAttribute("D")]
        [Description("International street address and postal code match")]
        InternationalStreetAddressAndPostalCodeMatch,

        [EnumValueAttribute("E")]
        [Description("Not a mail or phone order")]
        NotAMailOrPhoneOrder,

        [EnumValueAttribute("F")]
        [Description("Address and Postal Code match (UK only)")]
        AddressAndPostalCodeMatchUKOnly,

        [EnumValueAttribute("G")]
        [Description("Service Not supported, non-US Issuer does not participate")]
        ServiceNotSupportedNonUSIssuer,

        [EnumValueAttribute("I")]
        [Description("Address information not verified for international transaction")]
        AddressInformationNotVerifiedForInternationalTransaction,

        [EnumValueAttribute("M")]
        [Description("Address and Postal Code match")]
        AddressAndPostalCodeMatch,

        [EnumValueAttribute("N")]
        [Description("No match - No Address or ZIP Code match")]
        NoMatchNoAddressOrZIPCodeMatch,

        [EnumValueAttribute("P")]
        [Description("International postal code match, street address not verified due to incompatible format")]
        InternationalPostalCodeMatchStreetAddressNotVerified,

        [EnumValueAttribute("Q")]
        [Description("Bill to address did not pass edit checks/Card Association can't verify the authentication of an address")]
        BillToAddressDidNotPassEditChecksCardAssociationCantVerifyTheAuthenticationOfAnAddress,

        [EnumValueAttribute("R")]
        [Description("Retry - Issuer system unavailable, retry later")]
        RetryIssuerSystemUnavailable,

        [EnumValueAttribute("S")]
        [Description("Service not supported")]
        ServiceNotSupported,

        [EnumValueAttribute("W")]
        [Description("Partial match - ZIP Code matches, Street Address does not")]
        PartialMatchZIPCodeMatchesStreetAddressDoesNot,

        [EnumValueAttribute("U")]
        [Description("Unavailable - Address information is unavailable for that account number, or the card issuer does not support")]
        UnavailableAddressInformationIsUnavailableForThatAccountNumberOrTheCardIssuerDoesNotSupport,

        [EnumValueAttribute("X")]
        [Description("Exact match, 9 digit zip - Street Address, and 9 digit ZIP Code match")]
        ExactMatch9DigitZipStreetAddressAnd9DigitZIPCodeMatch,

        [EnumValueAttribute("Y")]
        [Description("Exact match, 5 digit zip - Street Address, and 5 digit ZIP Code match")]
        ExactMatch5DigitZipStreetAddressAnd5DigitZIPCodeMatch,

        [EnumValueAttribute("Z")]
        [Description("Partial match - 5 digit ZIP Code match only")]
        PartialMatch5DigitZIPCodeMatchOnly,

        [EnumValueAttribute("1")]
        [Description("Cardholder name matches")]
        CardholderNameMatches,

        [EnumValueAttribute("2")]
        [Description("Cardholder name, billing address, and postal code match")]
        CardholderNameBillingAddressAndPostalCodeMatch,

        [EnumValueAttribute("3")]
        [Description("Cardholder name and billing postal code match")]
        CardholderNameAndBillingPostalCodeMatch,

        [EnumValueAttribute("4")]
        [Description("Cardholder name and billing address match")]
        CardholderNameAndBillingAddressMatch,

        [EnumValueAttribute("5")]
        [Description("Cardholder name incorrect, billing address and postal code match")]
        CardholderNameIncorrectBillingAddressAndPostalCodeMatch,

        [EnumValueAttribute("6")]
        [Description("Cardholder name incorrect, billing postal code matches")]
        CardholderNameIncorrectBillingPostalCodeMatches,

        [EnumValueAttribute("7")]
        [Description("Cardholder name incorrect, billing address matches")]
        CardholderNameIncorrectBillingAddressMatches,

        [EnumValueAttribute("8")]
        [Description("Cardholder name, billing address, and postal code are all incorrect")]
        CardholderNameBillingAddressAndPostalCodeAreAllIncorrect
    }
}
