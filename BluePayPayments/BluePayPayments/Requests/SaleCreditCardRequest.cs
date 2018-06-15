using System;
using BluePayPayments.Attributes;
using BluePayPayments.Requests.Base;

namespace BluePayPayments.Requests
{
    public class SaleCreditCardRequest : SaleRequest
    {
        public string CardNumber { get; set; }

        [ParamName("CARD_CVV2")]
        public string CVV { get; set; }

        [ParamName("CARD_EXPIRE")]
        public string DateExpiration => new DateTime(YearExpiration, MonthExpiration, 1).ToString("MMyy"); //TODO: check

        public int MonthExpiration { get; set; }

        public int YearExpiration { get; set; }


        [ParamName("PAYMENT_ACCOUNT")]
        public override string PaymentAccount => CardNumber;
    }
}
