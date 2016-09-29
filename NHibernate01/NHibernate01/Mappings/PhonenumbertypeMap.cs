using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class PhonenumbertypeMap : ClassMap<Phonenumbertype> {
        
        public PhonenumbertypeMap() {
			Table("PhoneNumberType");
			LazyLoad();
			Id(x => x.Phonenumbertypeid).GeneratedBy.Identity().Column("PhoneNumberTypeID");
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
