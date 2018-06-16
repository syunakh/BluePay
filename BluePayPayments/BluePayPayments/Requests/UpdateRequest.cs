using BluePayPayments.Attributes;
using BluePayPayments.Requests.Base;

namespace BluePayPayments.Requests
{
    public class UpdateRequest : BaseRequest
    {
        public UpdateRequest() : base(TransactionType.UPDATE)
        {
        }

        [ParamName("MASTER_ID")]
        public string TransactionId { get; set; }

        [ParamName("AMOUNT")]
        public decimal Amount { get; set; }
    }
}
