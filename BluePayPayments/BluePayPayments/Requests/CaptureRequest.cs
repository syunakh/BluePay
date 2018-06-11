using System;
using System.Collections.Generic;
using System.Text;

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
