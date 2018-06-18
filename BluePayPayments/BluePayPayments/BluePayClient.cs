using BluePayPayments.Extensions;
using BluePayPayments.Http;
using BluePayPayments.Requests;
using BluePayPayments.Requests.Base;
using BluePayPayments.Responses.Base;

using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BluePayPayments
{
    public class BluePayClient : IBluePayClient
    {
        private readonly string _apiAccountId;
        private readonly string _apiSecretKey;
        private readonly bool _liveMode;
        private static CustomHttpClient _httpClient;

        private const string ApiUrl = "https://secure.bluepay.com/interfaces/bp20post";

        private string Mode => _liveMode ? "LIVE" : "TEST";

        static BluePayClient()
        {

        }

        public BluePayClient(string apiAccountId, string apiSecretKey, bool liveMode)
        {
            _apiAccountId = apiAccountId;
            _apiSecretKey = apiSecretKey;
            _liveMode = liveMode;

            ServicePointManager.CheckCertificateRevocationList = true;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }

        public async Task<BaseResponse> AuthorizeAsync(AuthorizeRequest request)
        {
            return await AuthorizeAsync<BaseResponse>(request);
        }

        public async Task<T> AuthorizeAsync<T>(AuthorizeRequest request) where T : BaseResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var calcMD5 = CalcTpsMd5(request.Amount, request.CustomerInfo?.FirstName, request.PaymentAccount, request.TransactionType);
            return await SendAsync<T>(request, calcMD5);
        }

        public async Task<BaseResponse> SaleAsync(SaleRequest request)
        {
            return await SaleAsync<BaseResponse>(request);
        }

        public async Task<T> SaleAsync<T>(SaleRequest request) where T : BaseResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var calcMD5 = CalcTpsMd5(request.Amount, request.CustomerInfo?.FirstName, request.PaymentAccount, request.TransactionType);
            return await SendAsync<T>(request, calcMD5);
        }

        public async Task<BaseResponse> CaptureAsync(CaptureRequest request)
        {
            return await CaptureAsync<BaseResponse>(request);
        }

        public async Task<T> CaptureAsync<T>(CaptureRequest request) where T : BaseResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var calcMD5 = CalcTpsMd5(request.Amount, null, null, request.TransactionType, request.TransactionId);
            return await SendAsync<T>(request, calcMD5);
        }

        public async Task<BaseResponse> RefundAsync(RefundRequest request)
        {
            return await RefundAsync<BaseResponse>(request);
        }

        public async Task<T> RefundAsync<T>(RefundRequest request) where T : BaseResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var calcMD5 = CalcTpsMd5(request.Amount, null, null, request.TransactionType, request.TransactionId);
            return await SendAsync<T>(request, calcMD5);
        }

        public async Task<BaseResponse> VoidAsync(VoidRequest request)
        {
            return await VoidAsync<BaseResponse>(request);
        }

        public async Task<T> VoidAsync<T>(VoidRequest request) where T : BaseResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var calcMD5 = CalcTpsMd5(null, null, null, request.TransactionType, request.TransactionId);
            return await SendAsync<T>(request, calcMD5);
        }

        public async Task<BaseResponse> UpdateAsync(UpdateRequest request)
        {
            return await UpdateAsync<BaseResponse>(request);
        }

        public async Task<T> UpdateAsync<T>(UpdateRequest request) where T : BaseResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var calcMD5 = CalcTpsMd5(request.Amount, null, null, request.TransactionType, request.TransactionId);
            return await SendAsync<T>(request, calcMD5);
        }

        #region Private

        private HttpClient BPHttpClient
        {
            get
            {
                if (_httpClient == null || _httpClient.IsDisposed)
                {
                    _httpClient = new CustomHttpClient();
                }

                return _httpClient;
            }
        }

        protected async Task<T> SendAsync<T>(BaseRequest request, string calcMD5) where T : BaseResponse
        {
            var prms = request.ToDictionaryParams(Mode, calcMD5, _apiAccountId);

            var response = await BPHttpClient.PostAsync(ApiUrl, new FormUrlEncodedContent(prms));

            //response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            return (T)Activator.CreateInstance(typeof(T), new object[] { result }); // result.ToBaseResponse<T>();
        }

        protected string CalcTpsMd5(decimal? amount, string name, string paymentAccount, TransactionType transactionType, string transactionId = null)
        {
            var nameOfTransactionType = transactionType.GetEnumName();
            //SECRET KEY + ACCOUNT_ID + TRANS_TYPE + AMOUNT + MASTER_ID + NAME1 + PAYMENT_ACCOUNT
            var tamperProofSeal = $"{_apiSecretKey}{_apiAccountId}{nameOfTransactionType}{amount:0.00}{transactionId}{name}{paymentAccount}";

            var md5 = new MD5CryptoServiceProvider();
            var encode = new UTF8Encoding();

            var buffer = encode.GetBytes(tamperProofSeal);
            var hash = md5.ComputeHash(buffer);
            return ByteArrayToString(hash);
        }

        private static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            var sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }



        #endregion
    }
}