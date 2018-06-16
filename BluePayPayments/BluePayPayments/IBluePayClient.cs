using BluePayPayments.Requests;
using BluePayPayments.Requests.Base;
using BluePayPayments.Responses.Base;

using System.Threading.Tasks;

namespace BluePayPayments
{
    public interface IBluePayClient
    {
        /// <summary>
        /// Authorizes the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> AuthorizeAsync(AuthorizeRequest request);

        /// <summary>
        /// Captures the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> CaptureAsync(CaptureRequest request);

        /// <summary>
        /// Sales the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> SaleAsync(SaleRequest request);

        /// <summary>
        /// Refunds the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> RefundAsync(RefundRequest request);

        /// <summary>
        /// Voids the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> VoidAsync(VoidRequest request);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> UpdateAsync(UpdateRequest request);
    }
}
