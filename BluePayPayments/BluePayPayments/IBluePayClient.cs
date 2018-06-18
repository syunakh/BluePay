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
        /// Authorizes the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<T> AuthorizeAsync<T>(AuthorizeRequest request) where T: BaseResponse;

        /// <summary>
        /// Captures the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> CaptureAsync(CaptureRequest request);

        /// <summary>
        /// Captures the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<T> CaptureAsync<T>(CaptureRequest request) where T : BaseResponse;

        /// <summary>
        /// Sales the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> SaleAsync(SaleRequest request);

        /// <summary>
        /// Sales the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<T> SaleAsync<T>(SaleRequest request) where T : BaseResponse;

        /// <summary>
        /// Refunds the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> RefundAsync(RefundRequest request);

        /// <summary>
        /// Refunds the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<T> RefundAsync<T>(RefundRequest request) where T : BaseResponse;

        /// <summary>
        /// Voids the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> VoidAsync(VoidRequest request);

        /// <summary>
        /// Voids the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<T> VoidAsync<T>(VoidRequest request) where T : BaseResponse;

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<BaseResponse> UpdateAsync(UpdateRequest request);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<T> UpdateAsync<T>(UpdateRequest request) where T : BaseResponse;
    }
}
