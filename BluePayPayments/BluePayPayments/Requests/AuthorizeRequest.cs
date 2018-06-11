using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public abstract class AuthorizeRequest : BaseRequest
    {
        protected AuthorizeRequest() : base(TransactionType.AUTH)
        {
        }

        public CustomerInfo CustomerInfo { get; set; }

        [ParamName("AMOUNT")]
        public decimal Amount { get; set; }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new System.NotImplementedException();
    }
}
