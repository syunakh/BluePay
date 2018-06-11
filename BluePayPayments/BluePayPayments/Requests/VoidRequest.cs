using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public class VoidRequest : BaseRequest
    {
        public VoidRequest() : base(TransactionType.VOID)
        {
        }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new NotImplementedException();
    }
}
