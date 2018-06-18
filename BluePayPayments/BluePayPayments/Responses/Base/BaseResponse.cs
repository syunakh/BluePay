using BluePayPayments.Attributes;
using BluePayPayments.Enums;

using System;
using System.Linq;
using System.Web;

namespace BluePayPayments.Responses.Base
{
    public class BaseResponse
    {
        public BaseResponse(string responseText)
        {
            ResponseBody = responseText;
            ToBaseResponse(ResponseBody);
        }

        [ParamName("TRANS_TYPE")]
        public TransactionType TransactionType { get; set; }

        [ParamName("REBID")]
        public string Rebid { get; set; }

        [ParamName("CVV2")]
        public CVVStatus Cvv { get; set; }

        [ParamName("AUTH_CODE")]
        public string AuthCode { get; set; }

        [ParamName("PAYMENT_ACCOUNT_MASK")]
        public string PaymentAccountMask { get; set; }

        [ParamName("AVS")]
        public AVSStatus AVS { get; set; }

        [ParamName("MESSAGE")]
        public string Message { get; set; }

        [ParamName("CARD_TYPE")]
        public string CardType { get; set; }

        [ParamName("TRANS_ID")]
        public string TransactionId { get; set; }

        [ParamName("STATUS")]
        public StatusResponse Status { get; set; }

        public string ResponseBody { get; }

        private void ToBaseResponse(string response)
        {
            var parsedQuery = HttpUtility.ParseQueryString($"?{response}");

            foreach (var prop in this.GetType().GetProperties())
            {
                var propNameAttr = prop.GetCustomAttributes(true).ToList()
                    .Find(f => f is ParamNameAttribute) as ParamNameAttribute;

                if (propNameAttr != null)
                {
                    var name = propNameAttr.Name;
                    var value = parsedQuery.Get(name);

                    if (string.IsNullOrEmpty(value)) continue;

                    var propType = prop.PropertyType;
                    if (propType.IsEnum)
                    {
                        foreach (var enumValue in Enum.GetValues(propType))
                        {
                            var memInfo = propType.GetMember(enumValue.ToString());
                            if (memInfo.Length <= 0) continue;
                            var attr = memInfo[0].GetCustomAttributes(typeof(EnumValueAttribute), false).FirstOrDefault() as EnumValueAttribute;

                            if ((attr != null
                                    && attr.Value?.ToLower() == value.ToLower())
                                || string.Equals(enumValue.ToString(), value, StringComparison.OrdinalIgnoreCase))
                            {
                                prop.SetValue(this, Enum.Parse(propType, enumValue.ToString()));
                                break;
                            }
                        }
                    }
                    else
                    {
                        prop.SetValue(this, value);
                    }
                }
            }
        }
    }
}
