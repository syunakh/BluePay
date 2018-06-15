using System;
using System.IO;
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
                    var keys = JsonConvert.DeserializeObject<BluePayKeys>(File.ReadAllText(@"key.json"));
                    _bluePayClient = new BluePayClient(keys.AccountId, keys.SecretKey, keys.Sandbox);
                }

                return _bluePayClient;
            }
        }

        private class BluePayKeys
        {
            public string AccountId { get; set; }
            public string SecretKey { get; set; }
            public bool Sandbox { get; set; }
        }
    }
}
