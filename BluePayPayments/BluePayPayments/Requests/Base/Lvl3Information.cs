using BluePayPayments.Attributes;

namespace BluePayPayments.Requests.Base
{
    public class Lvl3Information : IPropertyContainer
    {
        [ParamName("LV3_ITEM{INDEX}_ITEM_SKU")]
        public string ItemSku { get; set; }

        [ParamName("LV3_ITEM{INDEX}_ITEM_DESCRIPTOR")]
        public string ItemDescription { get; set; }

        [ParamName("LV3_ITEM{INDEX}_COMMODITY_CODE")]
        public string CommodityCode { get; set; }

        [ParamName("LV3_ITEM{INDEX}_PRODUCT_CODE")]
        public string ProductCode { get; set; }

        [ParamName("LV3_ITEM{INDEX}_MEASURE_UNITS")]
        public string MeasureUnits { get; set; }

        [ParamName("LV3_ITEM{INDEX}_UNIT_COST")]
        public decimal? UnitCost { get; set; }

        [ParamName("LV3_ITEM{INDEX}_QUANTITY")]
        public int? Quantity { get; set; }

        [ParamName("LV3_ITEM{INDEX}_ITEM_DISCOUNT")]
        public decimal? ItemDiscount { get; set; }

        [ParamName("LV3_ITEM{INDEX}_TAX_RATE")]
        public decimal? TaxRate { get; set; }

        [ParamName("LV3_ITEM{INDEX}_GOODS_TAX_RATE")]
        public decimal? GoodsTaxRate { get; set; }

        [ParamName("LV3_ITEM{INDEX}_TAX_AMOUNT")]
        public decimal? TaxAmount { get; set; }

        [ParamName("LV3_ITEM{INDEX}_GOODS_TAX_AMOUNT")]
        public decimal? GoodsTaxAmount { get; set; }

        [ParamName("LV3_ITEM{INDEX}_CITY_TAX_RATE")]
        public decimal? CityTaxRate { get; set; }

        [ParamName("LV3_ITEM{INDEX}_CITY_TAX_AMOUNT")]
        public decimal? CityTaxAmount { get; set; }

        [ParamName("LV3_ITEM{INDEX}_COUNTY_TAX_RATE")]
        public decimal? CountryTaxRate { get; set; }

        [ParamName("LV3_ITEM{INDEX}_COUNTY_TAX_AMOUNT")]
        public decimal? CountryTaxAmount { get; set; }

        [ParamName("LV3_ITEM{INDEX}_STATE_TAX_RATE")]
        public decimal? StateTaxRate { get; set; }

        [ParamName("LV3_ITEM{INDEX}_STATE_TAX_AMOUNT")]
        public decimal? StateTaxAmount { get; set; }

        [ParamName("LV3_ITEM{INDEX}_CUST_SKU")]
        public string CustSku { get; set; }

        [ParamName("LV3_ITEM{INDEX}_CUST_PO")]
        public string CustPo { get; set; }

        [ParamName("LV3_ITEM{INDEX}_SUPPLEMENTAL_DATA")]
        public string SupplementalData { get; set; }

        [ParamName("LV3_ITEM{INDEX}_GL_ACCOUNT_NUMBER")]
        public string GlAccountNumber { get; set; }

        [ParamName("LV3_ITEM{INDEX}_DIVISION_NUMBER")]
        public string DivisionNumber { get; set; }

        [ParamName("LV3_ITEM{INDEX}_PO_LINE_NUMBER")]
        public string POLineNumber { get; set; }

        [ParamName("LV3_ITEM{INDEX}_LINE_ITEM_TOTAL")]
        public string LineItemTotal { get; set; }
    }
}
