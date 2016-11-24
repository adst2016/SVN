using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ShipMethod {
        public ShipMethod() { }
        public virtual int ShipMethodId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal ShipBase { get; set; }
        public virtual decimal ShipRate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
