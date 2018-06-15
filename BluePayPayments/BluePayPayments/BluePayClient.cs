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
            var prms = request.ToDictionaryParams();
            prms.Add("MODE", Mode);
            prms.Add("TAMPER_PROOF_SEAL", CalcTpsMd5(request.Amount, request.CustomerInfo?.FirstName, request.PaymentAccount, request.TransactionType));
            prms.Add("ACCOUNT_ID", _apiAccountId);

            var response = await BPHttpClient.PostAsync(ApiUrl, new FormUrlEncodedContent(prms));

            if (!response.IsSuccessStatusCode)
            {

            }

            var result = await response.Content.ReadAsStringAsync();

            return result.ToBaseResponse();
        }

        public async Task<BaseResponse> CaptureAsync(CaptureRequest request) => throw new NotImplementedException();
        public async Task<BaseResponse> SaleAsync(SaleRequest request) => throw new NotImplementedException();
        public async Task<BaseResponse> RefundAsync(RefundRequest request) => throw new NotImplementedException();
        public async Task<BaseResponse> VoidAsync(VoidRequest request) => throw new NotImplementedException();
        public async Task<BaseResponse> UpdateAsync(UpdateRequest request) => throw new NotImplementedException();
        public async Task<BaseResponse> CreditAsync(CreditRequest request) => throw new NotImplementedException();

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

        private string CalcTpsMd5(decimal? amount, string name, string paymentAccount, TransactionType transactionType, string transactionId = null)
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