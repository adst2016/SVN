using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class BusinessentityaddressMap : ClassMap<Businessentityaddress> {
        
        public BusinessentityaddressMap() {
			Table("BusinessEntityAddress");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Businessentityid, "BusinessEntityID")
			             .KeyProperty(x => x.Addressid, "AddressID")
			             .KeyProperty(x => x.Addresstypeid, "AddressTypeID");
			References(x => x.Businessentity).Column("BusinessEntityID");
			References(x => x.Address).Column("AddressID");
			References(x => x.Addresstype).Column("AddressTypeID");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
