using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;

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
