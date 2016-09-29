using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class CountryregionMap : ClassMap<Countryregion> {
        
        public CountryregionMap() {
			Table("CountryRegion");
			LazyLoad();
			Id(x => x.Countryregioncode).GeneratedBy.Assigned().Column("CountryRegionCode");
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
