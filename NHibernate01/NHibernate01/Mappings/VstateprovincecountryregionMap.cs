using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class VstateprovincecountryregionMap : ClassMap<Vstateprovincecountryregion> {
        
        public VstateprovincecountryregionMap() {
			Table("vStateProvinceCountryRegion");
			LazyLoad();
			Map(x => x.Stateprovinceid).Column("StateProvinceID").Not.Nullable();
			Map(x => x.Stateprovincecode).Column("StateProvinceCode").Not.Nullable();
			Map(x => x.Isonlystateprovinceflag).Column("IsOnlyStateProvinceFlag").Not.Nullable();
			Map(x => x.Stateprovincename).Column("StateProvinceName").Not.Nullable();
			Map(x => x.Territoryid).Column("TerritoryID").Not.Nullable();
			Map(x => x.Countryregioncode).Column("CountryRegionCode").Not.Nullable();
			Map(x => x.Countryregionname).Column("CountryRegionName").Not.Nullable();
        }
    }
}
