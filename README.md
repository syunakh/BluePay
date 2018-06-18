# BluePayPayments

## Description

BluePay .Net Gateway interface

Used https://www.bluepay.com/sites/default/files/documentation/BluePay_bp20post/Bluepay20post.txt

## Nuget

```
Install-Package BluePayPayments
```

https://www.nuget.org/packages/BluePayPayments/

## Example

```
var bluePayClient = new BluePayClient(accountId, secretKey, !sandbox);

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

request.AdditionalInformation.OrderId = "1";
request.AdditionalInformation.AmountFood = 1;

var response = await bluePayClient.AuthorizeAsync(request);
```

## Extensibility

If you need a parameter that is not implemented in the default request the Request classes can be extended.

For example,

You need to add **BIRTHDATE** to your Authorize request.

You should create your class inheriting the base class and add needed parameters.

```
public class AuthorizeRequestWithBirthDate : AuthorizeCreditCardRequest
{
	[ParamName("BIRTHDATE")]
	public string BirthDate { get; set; }
}
```

Then use this type for request.

The same for Response: if you want use Version 2,3 or any other, you should inherit class BaseResponse and add needed fields with ParamName attribute.

Call generic methods for using the custom response type

For example, 


```
public class SaleVersion3Response : BaseResponse
{
	public SaleVersion3Response(string responseText) : base(responseText){
	}
	
	[ParamName("BANK_NAME")
	public string BankName {get; set;}
	...
	...

}
```

```
var bluePayClient = new BluePayClient(accountId, secretKey, !sandbox);

var request = new SaleRequest
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
	},
	Version = Version.Version3
};

var response = await bluePayClient.SaleAsync<SaleVersion3Response>(request);

```
