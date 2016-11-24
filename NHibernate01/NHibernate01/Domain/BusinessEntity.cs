using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class BusinessEntity {
        public BusinessEntity() { }
        public virtual int BusinessEntityId { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
