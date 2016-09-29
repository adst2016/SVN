using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class VadditionalcontactinfoMap : ClassMap<Vadditionalcontactinfo> {
        
        public VadditionalcontactinfoMap() {
			Table("vAdditionalContactInfo");
			LazyLoad();
			Map(x => x.Businessentityid).Column("BusinessEntityID").Not.Nullable();
			Map(x => x.Firstname).Column("FirstName").Not.Nullable();
			Map(x => x.Middlename).Column("MiddleName");
			Map(x => x.Lastname).Column("LastName").Not.Nullable();
			Map(x => x.Telephonenumber).Column("TelephoneNumber");
			Map(x => x.Telephonespecialinstructions).Column("TelephoneSpecialInstructions");
			Map(x => x.Street).Column("Street");
			Map(x => x.City).Column("City");
			Map(x => x.Stateprovince).Column("StateProvince");
			Map(x => x.Postalcode).Column("PostalCode");
			Map(x => x.Countryregion).Column("CountryRegion");
			Map(x => x.Homeaddressspecialinstructions).Column("HomeAddressSpecialInstructions");
			Map(x => x.Emailaddress).Column("EMailAddress");
			Map(x => x.Emailspecialinstructions).Column("EMailSpecialInstructions");
			Map(x => x.Emailtelephonenumber).Column("EMailTelephoneNumber");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
