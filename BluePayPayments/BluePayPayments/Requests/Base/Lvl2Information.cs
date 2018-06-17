using BluePayPayments.Attributes;

namespace BluePayPayments.Requests.Base
{
    public class Lvl2Information : IPropertyContainer
    {
        [ParamName("LV2_ITEM_TAX_RATE")]
        public decimal? TaxRate { get; set; }

        [ParamName("LV2_ITEM_GOODS_TAX_RATE")]
        public decimal? GoodsTaxRate { get; set; }

        [ParamName("LV2_ITEM_GOODS_TAX_AMOUNT")]
        public decimal? GoodsTaxAmount { get; set; }

        [ParamName("LV2_ITEM_SHIPPING_AMOUNT")]
        public decimal? ShippingAmount { get; set; }

        [ParamName("LV2_ITEM_DISCOUNT_AMOUNT")]
        public decimal? DiscountAmount { get; set; }

        [ParamName("LV2_ITEM_CUST_PO")]
        public string CustPO { get; set; }

        [ParamName("LV2_ITEM_GOODS_TAX_ID")]
        public string GoodsTaxId { get; set; }

        [ParamName("LV2_ITEM_TAX_ID")]
        public string TaxId { get; set; }

        [ParamName("LV2_ITEM_CUSTOMER_TAX_ID")]
        public string CustomerTaxId { get; set; }

        [ParamName("LV2_ITEM_DUTY_AMOUNT")]
        public decimal? DutyAmount { get; set; }

        [ParamName("LV2_ITEM_SUPPLEMENTAL_DATA")]
        public string SupplementalData { get; set; }

        [ParamName("LV2_ITEM_CITY_TAX_RATE")]
        public decimal? CityTaxRate { get; set; }

        [ParamName("LV2_ITEM_CITY_TAX_AMOUNT")]
        public decimal? CityTaxAmount { get; set; }

        [ParamName("LV2_ITEM_COUNTY_TAX_RATE")]
        public decimal? CountryTaxRate { get; set; }

        [ParamName("LV2_ITEM_COUNTY_TAX_AMOUNT")]
        public decimal? CountryTaxAmount { get; set; }

        [ParamName("LV2_ITEM_STATE_TAX_RATE")]
        public decimal? StateTaxRate { get; set; }

        [ParamName("LV2_ITEM_STATE_TAX_AMOUNT")]
        public decimal? StateaxAmount { get; set; }

        [ParamName("LV2_ITEM_BUYER_NAME")]
        public string BuyerName { get; set; }

        [ParamName("LV2_ITEM_CUSTOMER_REFERENCE")]
        public string CustomerReference { get; set; }

        [ParamName("LV2_ITEM_CUSTOMER_NUMBER")]
        public string CustomerNumber { get; set; }

        [ParamName("LV2_ITEM_SHIP_NAME")]
        public string ShipName { get; set; }

        [ParamName("LV2_ITEM_SHIP_ADDR1")]
        public string ShipAddress1 { get; set; }

        [ParamName("LV2_ITEM_SHIP_ADDR2")]
        public string ShipAddress2 { get; set; }

        [ParamName("LV2_ITEM_SHIP_CITY")]
        public string ShipCity { get; set; }

        [ParamName("LV2_ITEM_SHIP_STATE")]
        public string ShipState { get; set; }

        [ParamName("LV2_ITEM_SHIP_ZIP")]
        public string ShipZip { get; set; }

        [ParamName("LV2_ITEM_SHIP_COUNTRY")]
        public string ShipCountry { get; set; }
    }
}
