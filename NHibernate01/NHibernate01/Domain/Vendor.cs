using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Vendor {
        public Vendor() { }
        public virtual int BusinessEntityId { get; set; }
        public virtual BusinessEntity FkVendorBusinessEntityBusinessEntityId { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual byte CreditRating { get; set; }
        public virtual bool PreferredVendorStatus { get; set; }
        public virtual bool ActiveFlag { get; set; }
        public virtual string PurchasingWebServiceUrl { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
