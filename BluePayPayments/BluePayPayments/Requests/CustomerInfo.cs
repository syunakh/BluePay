namespace BluePayPayments.Requests
{
    public abstract class CustomerInfo
    {
        [ParamName("NAME1")]
        public string FirstName { get; set; }

        [ParamName("NAME2")]
        public string LastName { get; set; }

        [ParamName("ADDR1")]
        public string Address1 { get; set; }

        [ParamName("ADDR2")]
        public string Address2 { get; set; }

        [ParamName("CITY")]
        public string City { get; set; }

        [ParamName("STATE")]
        public string State { get; set; }

        [ParamName("ZIP")]
        public string Zip { get; set; }

        [ParamName("COUNTRY")]
        public string Country { get; set; }

        [ParamName("PHONE")]
        public string Phone { get; set; }

        [ParamName("EMAIL")]
        public string Email { get; set; }

        [ParamName("COMPANY_NAME")]
        public string CompanyName { get; set; }

        [ParamName("IS_CORPORATE")]
        public bool IsCorporate { get; set; }

        [ParamName("CUSTOMER_IP")]
        public string Ip { get; set; }
    }
}
