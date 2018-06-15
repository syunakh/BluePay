using BluePayPayments.Attributes;

namespace BluePayPayments.Requests.Base
{
    public abstract class SaleRequest : BaseRequest
    {
        protected SaleRequest() : base(TransactionType.SALE)
        {
        }

        public CustomerInfo CustomerInfo { get; set; }

        [ParamName("AMOUNT")]
        public decimal Amount { get; set; }

        public abstract string PaymentAccount { get; }
    }
}
