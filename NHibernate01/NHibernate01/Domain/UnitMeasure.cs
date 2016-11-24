using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class UnitMeasure {
        public UnitMeasure() { }
        public virtual string UnitMeasureCode { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
