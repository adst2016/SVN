using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class PurchaseOrderHeader {
        public PurchaseOrderHeader() { }
        public virtual int PurchaseOrderId { get; set; }
        public virtual Employee FkPurchaseOrderHeaderEmployeeEmployeeId { get; set; }
        public virtual Vendor FkPurchaseOrderHeaderVendorVendorId { get; set; }
        public virtual ShipMethod FkPurchaseOrderHeaderShipMethodShipMethodId { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual byte Status { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime? ShipDate { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
