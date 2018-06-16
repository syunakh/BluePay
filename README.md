# BluePayPayments

## Description

BluePay .Net Gateway interface

Used https://www.bluepay.com/sites/default/files/documentation/BluePay_bp20post/Bluepay20post.txt

## Install

```
Install-Package BluePayPayments
```

## Example

```
var bluePayClient = new BluePayClient(keys.AccountId, keys.SecretKey, !keys.Sandbox);

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

request.Settings.OrderId = "1";
request.Settings.AmountFood = 1;

var response = await bluePayClient.AuthorizeAsync(request);
```

## Extensibility

Request classes can be extended if you need a parameter that is not implemented in the default request.

For Example,
if you want to add **BIRTHDATE** to you Authorize request.

You should add this field by inherited of base class

```
public class AuthorizeRequestWithBirthDate : AuthorizeCreditCardRequest
{
	[ParamName("BIRTHDATE")]
	public string BirthDate { get; set; }
}
```

and use it for request
