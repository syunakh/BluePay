﻿using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public class CreditRequest : BaseRequest
    {
        public CreditRequest() : base(TransactionType.CREDIT)
        {
        }
        
    }
}
