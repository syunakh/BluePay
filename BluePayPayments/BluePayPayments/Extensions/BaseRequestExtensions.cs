using BluePayPayments.Attributes;
using BluePayPayments.Requests.Base;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BluePayPayments.Extensions
{
    internal static class BaseRequestExtensions
    {
        public static Dictionary<string, string> ToDictionaryParams(this BaseRequest baseRequest, string mode, string calcMD5, string accountId)
        {
            var result = new Dictionary<string, string>();

            if (baseRequest != null)
            {
                ConvertParams(baseRequest, result);
            }

            result.Add("MODE", mode);
            result.Add("TAMPER_PROOF_SEAL", calcMD5);
            result.Add("ACCOUNT_ID", accountId);

            return result;
        }

        private static void ConvertParams(object obj, Dictionary<string, string> result)
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                var val = prop.GetValue(obj, null);

                if (val == null) continue;
                var type = prop.PropertyType;
                if (typeof(IPropertyContainer).IsAssignableFrom(type))
                {
                    ConvertParams(val, result);
                }
                else
                {
                    if (prop.GetCustomAttributes(true).ToList().Find(f => f is ParamNameAttribute) is ParamNameAttribute propNameAttr)
                    {
                        var key = propNameAttr.Name.ToUpper();
                        string valString;

                        if (type.IsEnum)
                        {
                            valString = Enum.GetName(type, val);

                            foreach (var enumValue in Enum.GetValues(type))
                            {
                                var name = enumValue.ToString();

                                if(valString != name) continue;

                                var memInfo = type.GetMember(name);
                                if (memInfo.Length <= 0) continue;

                                if (memInfo[0].GetCustomAttributes(typeof(EnumValueAttribute), false).FirstOrDefault() is EnumValueAttribute attr)
                                {
                                    valString = attr.Value;
                                    break;
                                }
                            }
                            
                        }
                        else if (typeof(Decimal).IsAssignableFrom(type))
                        {
                            valString = ((decimal)val).ToString("0.00");
                        }
                        else
                        {
                            valString = val.ToString();
                        }

                        if (result.ContainsKey(key))
                        {
                            result[key] = valString;
                        }
                        else
                        {
                            result.Add(key, valString);
                        }
                    }
                }
            }
        }
    }
}
