using BluePayPayments.Requests;
using System.Threading.Tasks;

namespace BluePayPayments
{
    public interface IBluePayClient
    {
        Task AuthorizeAsync(AuthorizeRequest request);
        Task CaptureAsync(CaptureRequest request);
        Task SaleAsync(SaleRequest request);
        Task RefundAsync(RefundRequest request);
        Task VoidAsync(VoidRequest request);
        Task UpdateAsync(UpdateRequest request);
        Task CreditAsync(CreditRequest request);
    }
}
