using System;
using System.Collections.Generic;
using System.Text;

namespace BluePayPayments.Requests
{
    public class RefundRequest : BaseRequest
    {
        public RefundRequest() : base(TransactionType.REFUND)
        {
        }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new NotImplementedException();
    }
}
