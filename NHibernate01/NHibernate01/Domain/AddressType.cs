using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class AddressType {
        public AddressType() { }
        public virtual int AddressTypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
