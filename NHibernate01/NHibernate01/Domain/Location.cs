using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Location {
        public Location() { }
        public virtual short LocationId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal CostRate { get; set; }
        public virtual decimal Availability { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
