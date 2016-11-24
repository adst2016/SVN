using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Customer {
        public Customer() { }
        public virtual int CustomerId { get; set; }
        public virtual Person FkCustomerPersonPersonId { get; set; }
        public virtual Store FkCustomerStoreStoreId { get; set; }
        public virtual SalesTerritory FkCustomerSalesTerritoryTerritoryId { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
