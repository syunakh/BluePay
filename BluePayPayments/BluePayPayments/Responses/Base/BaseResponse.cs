using BluePayPayments.Attributes;
using BluePayPayments.Enums;
using Newtonsoft.Json;

namespace BluePayPayments.Responses.Base
{
    public class BaseResponse
    {
        [ParamName("TRANS_TYPE")]
        public TransactionType TransactionType { get; set; }

        [ParamName("REBID")]
        public string Rebid { get; set; }

        [ParamName("CVV2")]
        public CVVStatus Cvv { get; set; }

        [ParamName("AUTH_CODE")]
        public string AuthCode { get; set; }

        [ParamName("PAYMENT_ACCOUNT_MASK")]
        public string PaymentAccountMask { get; set; }

        [ParamName("AVS")]
        public AVSStatus AVS { get; set; }

        [ParamName("MESSAGE")]
        public string Message { get; set; }

        [ParamName("CARD_TYPE")]
        public string CardType { get; set; }

        [ParamName("TRANS_ID")]
        public string TransactionId { get; set; }

        [ParamName("STATUS")]
        public StatusResponse Status { get; set; }
    }
}
