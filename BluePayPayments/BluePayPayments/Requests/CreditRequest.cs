using System;
using System.Collections.Generic;
using System.Text;

namespace BluePayPayments.Requests
{
    public class CreditRequest : BaseRequest
    {
        public CreditRequest() : base(TransactionType.CREDIT)
        {
        }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new NotImplementedException();
    }
}
