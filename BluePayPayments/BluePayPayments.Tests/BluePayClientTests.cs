using BluePayPayments.Requests;
using BluePayPayments.Requests.Base;
using BluePayPayments.Responses.Base;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Threading.Tasks;

namespace BluePayPayments.Tests
{
    [TestClass]
    public class BluePayClientTests : BaseTests
    {
        [TestMethod]
        public async Task AuthorizeTest()
        {
            const decimal amount = 101;
            var response = await AuthorizeAsync(amount);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);
        }

        [TestMethod]
        public async Task CaptureTest()
        {
            const decimal amount = 101;
            var response = await AuthorizeAsync(amount);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);

            var captureResponse = await BluePayClient.CaptureAsync(new CaptureRequest
            {
                Amount = amount,
                TransactionId = response.TransactionId
            });

            Assert.IsTrue(Enums.StatusResponse.Approved == captureResponse.Status);
        }

        [TestMethod]
        public async Task SaleTest()
        {
            const decimal amount = 101;
            var response =await SaleAsync(amount);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);
        }

        [TestMethod]
        public async Task RefundTest()
        {
            const decimal amount = 101;
            var response = await SaleAsync(amount);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);

            var refundReponse = await BluePayClient.RefundAsync(new RefundRequest
            {
                Amount = amount - 50,
                TransactionId = response.TransactionId
            });

            Assert.IsTrue(refundReponse.Status == Enums.StatusResponse.Approved);
        }

        [TestMethod]
        public async Task VoidTest()
        {
            const decimal amount = 101;
            var response = await AuthorizeAsync(amount);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);

            var voidResponse = await BluePayClient.VoidAsync(new VoidRequest
            {
                TransactionId = response.TransactionId
            });

            Assert.IsTrue(voidResponse.Status == Enums.StatusResponse.Approved);
        }

        [TestMethod]
        public async Task UpdateTest()
        {
            const decimal amount = 101;
            var response = await SaleAsync(amount);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);

            var updateReponse = await BluePayClient.UpdateAsync(new UpdateRequest
            {
                Amount = amount + 50,
                TransactionId = response.TransactionId
            });

            Assert.IsTrue(updateReponse.Status == Enums.StatusResponse.Approved);
        }

        private Task<BaseResponse> AuthorizeAsync(decimal amount)
        {
            var request = new AuthorizeCreditCardRequest
            {
                CardNumber = "4111111111111111",
                CVV = "123",
                MonthExpiration = 12,
                YearExpiration = DateTime.Now.AddYears(1).Year,
                Amount = amount,
                CustomerInfo = new CustomerInfo
                {
                    FirstName = "Name",
                    LastName = "LastName"
                }
            };

            request.AdditionalInformation.OrderId = RandomString(200);

            request.AdditionalInformation.AmountFood = 1;

            return BluePayClient.AuthorizeAsync(request);
        }

        private Task<BaseResponse> SaleAsync(decimal amount)
        {
            var request = new SaleCreditCardRequest
            {
                CardNumber = "4111111111111111",
                CVV = "123",
                MonthExpiration = 12,
                YearExpiration = DateTime.Now.AddYears(1).Year,
                Amount = 101,
                CustomerInfo = new CustomerInfo
                {
                    FirstName = "Name",
                    LastName = "LastName"
                }
            };

            request.AdditionalInformation.OrderId = RandomString(200);

            request.AdditionalInformation.AmountFood = 1;

            return BluePayClient.SaleAsync(request);
        }
    }
}
