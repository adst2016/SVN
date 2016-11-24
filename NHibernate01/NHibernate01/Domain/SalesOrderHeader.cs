using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesOrderHeader {
        public SalesOrderHeader() { }
        public virtual int SalesOrderId { get; set; }
        public virtual Customer FkSalesOrderHeaderCustomerCustomerId { get; set; }
        public virtual SalesPerson FkSalesOrderHeaderSalesPersonSalesPersonId { get; set; }
        public virtual SalesTerritory FkSalesOrderHeaderSalesTerritoryTerritoryId { get; set; }
        public virtual Address FkSalesOrderHeaderAddressBillToAddressId { get; set; }
        public virtual Address FkSalesOrderHeaderAddressShipToAddressId { get; set; }
        public virtual ShipMethod FkSalesOrderHeaderShipMethodShipMethodId { get; set; }
        public virtual CreditCard FkSalesOrderHeaderCreditCardCreditCardId { get; set; }
        public virtual CurrencyRate FkSalesOrderHeaderCurrencyRateCurrencyRateId { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? ShipDate { get; set; }
        public virtual byte Status { get; set; }
        public virtual bool OnlineOrderFlag { get; set; }
        public virtual string SalesOrderNumber { get; set; }
        public virtual string PurchaseOrderNumber { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string CreditCardApprovalCode { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual string Comment { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
