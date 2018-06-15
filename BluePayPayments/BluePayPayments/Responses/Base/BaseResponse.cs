using Newtonsoft.Json;

namespace BluePayPayments.Responses.Base
{
    public class BaseResponse
    {
        [JsonProperty("TRANS_TYPE")]
        public string TransactionType { get; set; }

        [JsonProperty("REBID")]
        public string Rebid { get; set; }

        [JsonProperty("CVV2")]
        public string Cvv { get; set; }

        [JsonProperty("AUTH_CODE")]
        public string AuthCode { get; set; }

        [JsonProperty("PAYMENT_ACCOUNT_MASK")]
        public string PaymentAccountMask { get; set; }

        [JsonProperty("AVS")]
        public string AVS { get; set; }

        [JsonProperty("MESSAGE")]
        public string Message { get; set; }

        [JsonProperty("CARD_TYPE")]
        public string CardType { get; set; }

        [JsonProperty("TRANS_ID")]
        public string TransactionId { get; set; }

        [JsonProperty("STATUS")]
        public string Status { get; set; }
    }
}
