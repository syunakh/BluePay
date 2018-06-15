using BluePayPayments.Attributes;
using BluePayPayments.Requests.Base;

namespace BluePayPayments.Requests
{
    public class CaptureRequest : BaseRequest
    {
        public CaptureRequest() : base(TransactionType.CAPTURE)
        {
        }

        [ParamName("AMOUNT")]
        public decimal Amount { get; set; }

        [ParamName("MASTER_ID")]
        public string TransactionId { get; set; }
    }
}
