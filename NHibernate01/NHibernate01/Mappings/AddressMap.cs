using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class AddressMap : ClassMap<Address> {
        
        public AddressMap() {
			Table("Address");
			LazyLoad();
			Id(x => x.Addressid).GeneratedBy.Identity().Column("AddressID");
			References(x => x.Stateprovince).Column("StateProvinceID");
			Map(x => x.Addressline1).Column("AddressLine1").Not.Nullable();
			Map(x => x.Addressline2).Column("AddressLine2");
			Map(x => x.City).Column("City").Not.Nullable();
			Map(x => x.Postalcode).Column("PostalCode").Not.Nullable();
			Map(x => x.Spatiallocation).Column("SpatialLocation");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
