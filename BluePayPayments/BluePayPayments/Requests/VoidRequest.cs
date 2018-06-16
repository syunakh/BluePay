using BluePayPayments.Attributes;
using BluePayPayments.Requests.Base;

namespace BluePayPayments.Requests
{
    public class VoidRequest : BaseRequest
    {
        public VoidRequest() : base(TransactionType.VOID)
        {
        }

        [ParamName("MASTER_ID")]
        public string TransactionId { get; set; }
    }
}
