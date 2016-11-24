using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Shift {
        public Shift() { }
        public virtual byte ShiftId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
