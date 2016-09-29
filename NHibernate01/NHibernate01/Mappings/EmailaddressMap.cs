using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class EmailaddressMap : ClassMap<Emailaddress> {
        
        public EmailaddressMap() {
			Table("EmailAddress");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Businessentityid, "BusinessEntityID")
			             .KeyProperty(x => x.Emailaddressid, "EmailAddressID");
			References(x => x.Person).Column("BusinessEntityID");
			Map(x => x.EmailaddressVal).Column("EmailAddress");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
