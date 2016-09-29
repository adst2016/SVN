using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class BusinessentitycontactMap : ClassMap<Businessentitycontact> {
        
        public BusinessentitycontactMap() {
			Table("BusinessEntityContact");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Businessentityid, "BusinessEntityID")
			             .KeyProperty(x => x.Personid, "PersonID")
			             .KeyProperty(x => x.Contacttypeid, "ContactTypeID");
			References(x => x.Businessentity).Column("BusinessEntityID");
			References(x => x.Person).Column("PersonID");
			References(x => x.Contacttype).Column("ContactTypeID");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
