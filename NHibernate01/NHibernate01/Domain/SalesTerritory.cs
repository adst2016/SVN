using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesTerritory {
        public SalesTerritory() { }
        public virtual int TerritoryId { get; set; }
        public virtual CountryRegion FkSalesTerritoryCountryRegionCountryRegionCode { get; set; }
        public virtual string Name { get; set; }
        public virtual string Group { get; set; }
        public virtual decimal SalesYtd { get; set; }
        public virtual decimal SalesLastYear { get; set; }
        public virtual decimal CostYtd { get; set; }
        public virtual decimal CostLastYear { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
