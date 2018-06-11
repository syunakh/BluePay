using System.Collections.Generic;

namespace BluePayPayments.Requests
{
    public abstract class BaseRequest
    {
        private TransactionType TransactionType { get; }

        internal BaseRequest(TransactionType transactionType)
        {
            TransactionType = transactionType;
        }

        public AdditionalSettingsRequest Settings { get; } = new AdditionalSettingsRequest();

        internal abstract Dictionary<string, string> ToDictionaryParameters();
    }
}
