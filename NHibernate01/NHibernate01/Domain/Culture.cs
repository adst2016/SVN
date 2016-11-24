using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Culture {
        public Culture() { }
        public virtual string CultureId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
