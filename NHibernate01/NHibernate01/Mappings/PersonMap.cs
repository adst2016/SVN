using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class PersonMap : ClassMap<Person> {
        
        public PersonMap() {
			Table("Person");
			LazyLoad();
			Id(x => x.Businessentityid).GeneratedBy.Identity().Column("BusinessEntityID");
			References(x => x.Businessentity).Column("BusinessEntityID");
			Map(x => x.Persontype).Column("PersonType").Not.Nullable();
			Map(x => x.Namestyle).Column("NameStyle").Not.Nullable();
			Map(x => x.Title).Column("Title");
			Map(x => x.Firstname).Column("FirstName").Not.Nullable();
			Map(x => x.Middlename).Column("MiddleName");
			Map(x => x.Lastname).Column("LastName").Not.Nullable();
			Map(x => x.Suffix).Column("Suffix");
			Map(x => x.Emailpromotion).Column("EmailPromotion").Not.Nullable();
			Map(x => x.Additionalcontactinfo).Column("AdditionalContactInfo");
			Map(x => x.Demographics).Column("Demographics");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
