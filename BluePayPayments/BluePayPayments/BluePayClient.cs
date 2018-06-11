using BluePayPayments.Extensions;
using BluePayPayments.Requests;
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
        private static readonly HttpClient _httpClient;

        private const string ApiUrl = "https://secure.bluepay.com/interfaces/bp20post";

        private string Mode => _liveMode ? "LIVE" : "TEST";

        static BluePayClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiUrl)
            };
        }

        public BluePayClient(string apiAccountId, string apiSecretKey, bool liveMode)
        {
            _apiAccountId = apiAccountId ?? throw new ArgumentException($"{nameof(apiAccountId)} must have value in settings");
            _apiSecretKey = apiSecretKey ?? throw new ArgumentException($"{nameof(apiSecretKey)} must have value in settings");
            _liveMode = liveMode;

            ServicePointManager.CheckCertificateRevocationList = true;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }


        public async Task AuthorizeAsync(AuthorizeRequest request)
        {

        }

        public async Task CaptureAsync(CaptureRequest request) => throw new NotImplementedException();
        public async Task SaleAsync(SaleRequest request) => throw new NotImplementedException();
        public async Task RefundAsync(RefundRequest request) => throw new NotImplementedException();
        public async Task VoidAsync(VoidRequest request) => throw new NotImplementedException();
        public async Task UpdateAsync(UpdateRequest request) => throw new NotImplementedException();
        public async Task CreditAsync(CreditRequest request) => throw new NotImplementedException();

        #region Private

        private string CalcTpsMd5(decimal? amount, string name, string cardNumber, TransactionType transactionType, string transactionId = null)
        {
            var nameOfTransactionType = transactionType.GetEnumName();
            //SECRET KEY + ACCOUNT_ID + TRANS_TYPE + AMOUNT + MASTER_ID + NAME1 + PAYMENT_ACCOUNT
            var tamperProofSeal = $"{_apiSecretKey}{_apiAccountId}{nameOfTransactionType}{amount:0.00}{transactionId}{name}{cardNumber}";

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