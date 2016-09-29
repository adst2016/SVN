using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate01.Domain; 

namespace NHibernate01.Mappings {
    
    
    public class BusinessentityMap : ClassMap<Businessentity> {
        
        public BusinessentityMap() {
			Table("BusinessEntity");
			LazyLoad();
			Id(x => x.Businessentityid).GeneratedBy.Identity().Column("BusinessEntityID");
			Map(x => x.Rowguid).Column("rowguid").Not.Nullable();
			Map(x => x.Modifieddate).Column("ModifiedDate").Not.Nullable();
        }
    }
}
