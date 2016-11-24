using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesPerson {
        public SalesPerson() { }
        public virtual int BusinessEntityId { get; set; }
        public virtual Employee FkSalesPersonEmployeeBusinessEntityId { get; set; }
        public virtual SalesTerritory FkSalesPersonSalesTerritoryTerritoryId { get; set; }
        public virtual decimal? SalesQuota { get; set; }
        public virtual decimal Bonus { get; set; }
        public virtual decimal CommissionPct { get; set; }
        public virtual decimal SalesYtd { get; set; }
        public virtual decimal SalesLastYear { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
