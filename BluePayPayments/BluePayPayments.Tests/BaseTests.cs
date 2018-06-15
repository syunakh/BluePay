using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace BluePayPayments.Tests
{
    public abstract class BaseTests
    {
        private IBluePayClient _bluePayClient;

        protected IBluePayClient BluePayClient
        {
            get
            {
                if (_bluePayClient == null)
                {
                    var keys = JsonConvert.DeserializeObject<BluePayKeys>(File.ReadAllText(@"./../../../keys.json"));
                    _bluePayClient = new BluePayClient(keys.AccountId, keys.SecretKey, !keys.Sandbox);
                }

                return _bluePayClient;
            }
        }

        private static Random random = new Random();
        protected static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private class BluePayKeys
        {
            public string AccountId { get; set; }
            public string SecretKey { get; set; }
            public bool Sandbox { get; set; }
        }
    }
}
