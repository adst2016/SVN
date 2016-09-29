using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class PersonphoneMap : ClassMap<Personphone> {
        
        public PersonphoneMap() {
			Table("PersonPhone");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Businessentityid, "BusinessEntityID")
			             .KeyProperty(x => x.Phonenumber, "PhoneNumber")
			             .KeyProperty(x => x.Phonenumbertypeid, "PhoneNumberTypeID");
			References(x => x.Person).Column("BusinessEntityID");
			References(x => x.Phonenumbertype).Column("PhoneNumberTypeID");
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
