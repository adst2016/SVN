using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class PasswordMap : ClassMap<Password> {
        
        public PasswordMap() {
			Table("Password");
			LazyLoad();
			Id(x => x.Businessentityid).GeneratedBy.Identity().Column("BusinessEntityID");
			References(x => x.Person).Column("BusinessEntityID");
			Map(x => x.Passwordhash).Column("PasswordHash").Not.Nullable();
			Map(x => x.Passwordsalt).Column("PasswordSalt").Not.Nullable();
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
