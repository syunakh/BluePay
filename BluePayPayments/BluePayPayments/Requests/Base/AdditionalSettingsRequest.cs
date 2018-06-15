using System;
using BluePayPayments.Attributes;

namespace BluePayPayments.Requests.Base
{
    public class AdditionalSettingsRequest : IPropertyContainer
    {
        /// <summary>
        /// Gets or sets a value indicating whether [duplicate override].
        /// Optional, Set to 1 to turn of duplicate scrubbing for a transaction. Set to 0 or 
        /// leave blank to process with duplicate scrubbing.
        /// </summary>
        [ParamName("DUPLICATE_OVERRIDE")]
        public bool DuplicateOverride { get; set; } = false;

        /// <summary>
        /// Gets or sets the memo.
        /// Optional, 128-character descriptor field.
        /// </summary>
        [ParamName("MEMO")]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// Optional, Determines fields included in output. See output section below.
        /// </summary>
        [ParamName("VERSION")]
        public string Version { get; set; } = "1";

        /// <summary>
        /// Gets or sets the bp stamp definition.
        /// Optional, List of field names separated by spaces in the order they are to be used 
        /// in the calculation of BP_STAMP.See BP_STAMP in output section for more
        /// information.
        /// </summary>
        [ParamName("BP_STAMP_DEF")]
        public string BPStampDef { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// Optional, Optional Purchase Order ID (128 Characters)
        /// </summary>
        [ParamName("ORDER_ID")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the invoice identifier.
        /// Optional, Optional Invoice ID (64 Characters)
        /// </summary>
        [ParamName("INVOICE_ID")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Gets or sets the amount tip.
        /// Optional, The tip amount, if any.
        /// </summary>
        [ParamName("AMOUNT_TIP")]
        public decimal? AmountTip { get; set; }

        /// <summary>
        /// Gets or sets the amount tax.
        /// Optional, The tax amount, if any.
        /// </summary>
        [ParamName("AMOUNT_TAX")]
        public decimal? AmountTax { get; set; }

        /// <summary>
        /// Gets or sets the amount food.
        /// Optional, The amount of the total that was spent on food, for restaurants
        /// </summary>
        [ParamName("AMOUNT_FOOD")]
        public decimal? AmountFood { get; set; }

        /// <summary>
        /// Gets or sets the amount misc.
        /// Optional, The amount of the total that was spent on beverages and other.
        /// </summary>
        [ParamName("AMOUNT_MISC")]
        public decimal? AmountMisc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [do rebill].
        /// The following fields are to add rebilling to a SALE or AUTH:
        /// Note: Rebilling is only available to US merchants.
        /// </summary>
        [ParamName("DO_REBILL")]
        public bool? DoRebill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [reb is credit].
        /// The following fields are to add rebilling to a SALE or AUTH:
        /// Note: Rebilling is only available to US merchants.
        /// </summary>
        [ParamName("REB_IS_CREDIT")]
        public bool? RebIsCredit { get; set; }

        /// <summary>
        /// Gets or sets the reb first date.
        /// The following fields are to add rebilling to a SALE or AUTH:
        /// Note: Rebilling is only available to US merchants.
        /// </summary>
        [ParamName("REB_FIRST_DATE")]
        public DateTime? RebFirstDate { get; set; }

        /// <summary>
        /// Gets or sets the reb expiration.
        /// The following fields are to add rebilling to a SALE or AUTH:
        /// Note: Rebilling is only available to US merchants.
        /// </summary>
        /// <value>
        /// Format: "2 WEEK", "3 YEAR"
        /// </value>
        [ParamName("REB_EXPR")]
        public string RebExpiration { get; set; }

        /// <summary>
        /// Gets or sets the reb cycles. How many times
        /// The following fields are to add rebilling to a SALE or AUTH:
        /// Note: Rebilling is only available to US merchants.
        /// </summary>
        [ParamName("REB_CYCLES")]
        public int? RebCycles { get; set; }

        /// <summary>
        /// Gets or sets the reb mount.
        /// The following fields are to add rebilling to a SALE or AUTH:
        /// Note: Rebilling is only available to US merchants.
        /// </summary>
        [ParamName("REB_AMOUNT")]
        public decimal? RebMount { get; set; }

        /// <summary>
        /// Gets or sets the smid identifier.
        /// The following fields are available only when PAYMENT_TYPE is set to DEBIT
        /// Required, this is the encryption key information
        /// </summary>
        [ParamName("SMID_ID")]
        public string SMIDId { get; set; }

        /// <summary>
        /// Gets or sets the pin block.
        /// The following fields are available only when PAYMENT_TYPE is set to DEBIT
        /// Required, this is the encrypted PIN
        /// </summary>
        [ParamName("PIN_BLOCK")]
        public string PinBlock { get; set; }

        /// <summary>
        /// Gets or sets the amount cachback.
        /// The following fields are available only when PAYMENT_TYPE is set to DEBIT
        /// Optional, amount of cash given to customer
        /// </summary>
        [ParamName("AMOUNT_CASHBACK")]
        public decimal? AmountCachback { get; set; }

        /// <summary>
        /// Gets or sets the amount surcharge.
        /// The following fields are available only when PAYMENT_TYPE is set to DEBIT
        /// Optional, surcharge for performing cash back
        /// </summary>
        [ParamName("AMOUNT_SURCHARGE")]
        public decimal? AmountSurcharge { get; set; }

        /// <summary>
        /// Gets or sets the swipe.
        /// The full swiped track data, just the way it comes to you from the card reader, including both Track1 and Track2.
        /// Note that DEBIT also requires you to send either SWIPE or TRACK2.    
        /// </summary>
        [ParamName("SWIPE")]
        public string Swipe { get; set; }

        /// <summary>
        /// Gets or sets the track2.
        /// Only Track2 of the swiped data.
        /// Note that DEBIT also requires you to send either SWIPE or TRACK2.    
        /// </summary>
        [ParamName("TRACK2")]
        public string Track2 { get; set; }
    }
}
