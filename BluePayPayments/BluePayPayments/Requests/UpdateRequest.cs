using System;
using System.Collections.Generic;
using System.Text;

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
