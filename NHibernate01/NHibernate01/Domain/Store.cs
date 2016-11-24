using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Store {
        public Store() { }
        public virtual int BusinessEntityId { get; set; }
        public virtual BusinessEntity FkStoreBusinessEntityBusinessEntityId { get; set; }
        public virtual SalesPerson FkStoreSalesPersonSalesPersonId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
