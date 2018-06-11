using System;
using System.Collections.Generic;
using System.Text;

namespace BluePayPayments.Requests
{
    public class SaleRequest : BaseRequest
    {
        public SaleRequest() : base(TransactionType.SALE)
        {
        }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new NotImplementedException();
    }
}
