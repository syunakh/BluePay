using BluePayPayments.Attributes;
using BluePayPayments.Requests.Base;

namespace BluePayPayments.Requests
{
    public class RefundRequest : BaseRequest
    {
        public RefundRequest() : base(TransactionType.REFUND)
        {
        }

        [ParamName("AMOUNT")]
        public decimal Amount { get; set; }

        [ParamName("MASTER_ID")]
        public string TransactionId { get; set; }
    }
}
