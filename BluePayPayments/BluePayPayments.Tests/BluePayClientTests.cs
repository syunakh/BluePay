using BluePayPayments.Requests;
using BluePayPayments.Requests.Base;
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
            var request = new AuthorizeCreditCardRequest
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

            request.Settings.OrderId = RandomString(200);

            request.Settings.AmountFood = 1;

            var response = await BluePayClient.AuthorizeAsync(request);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);
        }

        [TestMethod]
        public async Task CaptureTest()
        {
            var request = new AuthorizeCreditCardRequest
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

            request.Settings.OrderId = RandomString(200);

            request.Settings.AmountFood = 1;

            var response = await BluePayClient.AuthorizeAsync(request);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);

            var captureResponse = await BluePayClient.CaptureAsync(new CaptureRequest
            {
                Amount = request.Amount,
                TransactionId = response.TransactionId
            });

            Assert.Equals(Enums.StatusResponse.Approved, captureResponse.Status);
        }

        [TestMethod]
        public async Task SaleTest()
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

            request.Settings.OrderId = RandomString(200);

            request.Settings.AmountFood = 1;

            var response = await BluePayClient.SaleAsync(request);

            Assert.IsTrue(response.Status == Enums.StatusResponse.Approved);
        }
    }
}
