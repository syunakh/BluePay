using System;
using System.Linq;
using System.Web;
using BluePayPayments.Attributes;
using BluePayPayments.Responses.Base;

namespace BluePayPayments.Extensions
{
    internal static class StringExtensions
    {
        internal static BaseResponse ToBaseResponse(this string response)
        {
            var result = new BaseResponse();

            var parsedQuery = HttpUtility.ParseQueryString($"?{response}");

            foreach (var prop in result.GetType().GetProperties())
            {
                var propNameAttr = prop.GetCustomAttributes(true).ToList()
                    .Find(f => f is ParamNameAttribute) as ParamNameAttribute;

                if (propNameAttr != null)
                {
                    var name = propNameAttr.Name;
                    var value = parsedQuery.Get(name);

                    if(string.IsNullOrEmpty(value)) continue;

                    var propType = prop.PropertyType;
                    if (propType.IsEnum)
                    {
                        foreach (var enumValue in Enum.GetValues(propType))
                        {
                            var memInfo = propType.GetMember(enumValue.ToString());
                            if (memInfo.Length <= 0) continue;
                            var attr = memInfo[0].GetCustomAttributes(typeof(ResponseEnumValueAttribute), false).FirstOrDefault() as ResponseEnumValueAttribute;

                            if (attr != null 
                                    && attr.Value?.ToLower() == value.ToLower() 
                                || enumValue.ToString().ToLower() == value.ToLower())
                            {
                                prop.SetValue(result, Enum.Parse(propType, enumValue.ToString()));
                                break;
                            }
                        }
                    }
                    else
                    {
                        prop.SetValue(result, value);
                    }
                }
            }

            return result;
        }
    }
}
