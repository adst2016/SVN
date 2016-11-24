using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class PhoneNumberType {
        public PhoneNumberType() { }
        public virtual int PhoneNumberTypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
