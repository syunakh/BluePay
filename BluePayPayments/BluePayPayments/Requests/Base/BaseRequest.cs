using BluePayPayments.Attributes;
using BluePayPayments.Enums;

namespace BluePayPayments.Requests.Base
{
    public abstract class BaseRequest
    {
        internal BaseRequest(TransactionType transactionType)
        {
            TransactionType = transactionType;
        }

        [ParamName("TRANS_TYPE")]
        public TransactionType TransactionType { get; }

        [ParamName("PAYMENT_TYPE")]
        public PaymentType PaymentType { get; set; } = PaymentType.CREDIT;

        [ParamName("VERSION")]
        public Version Version { get; set; } = Version.Version1;

        public AdditionalSettingsRequest AdditionalInformation { get; } = new AdditionalSettingsRequest();

    }
}
