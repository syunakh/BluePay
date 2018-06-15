using BluePayPayments.Requests;
using BluePayPayments.Requests.Base;
using BluePayPayments.Responses.Base;
using System.Threading.Tasks;

namespace BluePayPayments
{
    public interface IBluePayClient
    {
        Task<BaseResponse> AuthorizeAsync(AuthorizeRequest request);
        Task<BaseResponse> CaptureAsync(CaptureRequest request);
        Task<BaseResponse> SaleAsync(SaleRequest request);
        Task<BaseResponse> RefundAsync(RefundRequest request);
        Task<BaseResponse> VoidAsync(VoidRequest request);
        Task<BaseResponse> UpdateAsync(UpdateRequest request);
        Task<BaseResponse> CreditAsync(CreditRequest request);
    }
}
