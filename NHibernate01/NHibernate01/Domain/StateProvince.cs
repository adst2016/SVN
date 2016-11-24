using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class StateProvince {
        public StateProvince() { }
        public virtual int StateProvinceId { get; set; }
        public virtual CountryRegion FkStateProvinceCountryRegionCountryRegionCode { get; set; }
        public virtual SalesTerritory FkStateProvinceSalesTerritoryTerritoryId { get; set; }
        public virtual string StateProvinceCode { get; set; }
        public virtual bool IsOnlyStateProvinceFlag { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
