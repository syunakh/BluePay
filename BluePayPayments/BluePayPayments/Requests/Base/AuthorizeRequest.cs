using System.Collections.Generic;
using BluePayPayments.Attributes;

namespace BluePayPayments.Requests.Base
{
    public abstract class AuthorizeRequest : BaseRequest
    {
        protected AuthorizeRequest() : base(TransactionType.AUTH)
        {
        }

        public CustomerInfo CustomerInfo { get; set; }

        [ParamName("AMOUNT")]
        public decimal Amount { get; set; }

        public abstract string PaymentAccount { get; }


    }
}
