using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class SalesterritoryMap : ClassMap<Salesterritory> {
        
        public SalesterritoryMap() {
			Table("SalesTerritory");
			LazyLoad();
			Id(x => x.Territoryid).GeneratedBy.Identity().Column("TerritoryID");
			References(x => x.Countryregion).Column("CountryRegionCode");
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Group).Column("Group").Not.Nullable();
			Map(x => x.Salesytd).Column("SalesYTD").Not.Nullable();
			Map(x => x.Saleslastyear).Column("SalesLastYear").Not.Nullable();
			Map(x => x.Costytd).Column("CostYTD").Not.Nullable();
			Map(x => x.Costlastyear).Column("CostLastYear").Not.Nullable();
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
