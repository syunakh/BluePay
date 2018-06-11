using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public class UpdateRequest : BaseRequest
    {
        public UpdateRequest() : base(TransactionType.UPDATE)
        {
        }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new NotImplementedException();
    }
}
