using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class StateprovinceMap : ClassMap<Stateprovince> {
        
        public StateprovinceMap() {
			Table("StateProvince");
			LazyLoad();
			Id(x => x.Stateprovinceid).GeneratedBy.Identity().Column("StateProvinceID");
			References(x => x.Countryregion).Column("CountryRegionCode");
			References(x => x.Salesterritory).Column("TerritoryID");
			Map(x => x.Stateprovincecode).Column("StateProvinceCode").Not.Nullable();
			Map(x => x.Isonlystateprovinceflag).Column("IsOnlyStateProvinceFlag").Not.Nullable();
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
