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
        

        public BluePayClientTests()
        {
            
        }

        [TestMethod]
        public async Task AuthorizeTest()
        {
            var request = new AuthorizeCreditCardRequest
            {
                CardNumber = "4111111111111111",
                CVV = "123",
                MonthExpiration = 12,
                YearExpiration = DateTime.Now.AddYears(1).Year,
                Amount = 100,
                CustomerInfo = new CustomerInfo
                {
                    FirstName = "Name",
                    LastName = "LasName"
                }
            };

            request.Settings.AmountFood = 1;

            await BluePayClient.AuthorizeAsync(request);
        }
    }
}
