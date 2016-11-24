using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesReason {
        public SalesReason() { }
        public virtual int SalesReasonId { get; set; }
        public virtual string Name { get; set; }
        public virtual string ReasonType { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
