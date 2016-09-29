using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Address {
        public Address() { }
        public virtual int Addressid { get; set; }
        public virtual Stateprovince Stateprovince { get; set; }
        public virtual string Addressline1 { get; set; }
        public virtual string Addressline2 { get; set; }
        public virtual string City { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual string Spatiallocation { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
