using System.Collections.Generic;

namespace BluePayPayments.Requests.Base
{
    public abstract class BaseRequest
    {
        [ParamName("TRANS_TYPE")]
        public TransactionType TransactionType { get; }

        [ParamName("PAYMENT_TYPE")]
        public PaymentType PaymentType { get; set; } = PaymentType.CREDIT;

        internal BaseRequest(TransactionType transactionType)
        {
            TransactionType = transactionType;
        }

        public AdditionalSettingsRequest Settings { get; } = new AdditionalSettingsRequest();

    }
}
