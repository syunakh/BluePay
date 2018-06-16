# Install

```
Install-Package BluePayPayments
```

# Example

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

var response = bluePayClient.AuthorizeAsync(request);
```