namespace BluePayPayments
{
    public enum TransactionType
    {
        AUTH,
        SALE,
        REFUND,
        CAPTURE,
        VOID,
        UPDATE,
        CREDIT,
        AGG
    }

    public enum PaymentType
    {
        CREDIT,
        DEBIT,
        ACH
    }
}