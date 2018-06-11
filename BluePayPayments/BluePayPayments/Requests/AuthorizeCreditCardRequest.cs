using System;
using System.Collections.Generic;

namespace BluePayPayments.Requests
{

    public class AuthorizeCreditCardRequest : AuthorizeRequest
    {
        [ParamName("PAYMENT_ACCOUNT")]
        public string CardNumber { get; set; }

        [ParamName("CARD_CVV2")]
        public string CVV { get; set; }

        [ParamName("CARD_EXPIRE")]
        internal string DateExpiration => new DateTime(YearExpiration, MonthExpiration, 1).ToString("MMyy"); //TODO: check

        public int MonthExpiration { get; set; }

        public int YearExpiration { get; set; }

        internal override Dictionary<string, string> ToDictionaryParameters()
        {
            return base.ToDictionaryParameters();
        }
    }
}
