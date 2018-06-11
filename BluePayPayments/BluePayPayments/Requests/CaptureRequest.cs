using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public class CaptureRequest : BaseRequest
    {
        public CaptureRequest() : base(TransactionType.CAPTURE)
        {
        }

        internal override Dictionary<string, string> ToDictionaryParameters() => throw new NotImplementedException();
    }
}
