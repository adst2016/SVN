using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class ContacttypeMap : ClassMap<Contacttype> {
        
        public ContacttypeMap() {
			Table("ContactType");
			LazyLoad();
			Id(x => x.Contacttypeid).GeneratedBy.Identity().Column("ContactTypeID");
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
