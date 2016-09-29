using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class AddresstypeMap : ClassMap<Addresstype> {
        
        public AddresstypeMap() {
			Table("AddressType");
			LazyLoad();
			Id(x => x.Addresstypeid).GeneratedBy.Identity().Column("AddressTypeID");
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
