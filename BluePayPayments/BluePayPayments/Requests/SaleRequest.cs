using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public class SaleRequest : BaseRequest
    {
        public SaleRequest() : base(TransactionType.SALE)
        {
        }
        
    }
}
