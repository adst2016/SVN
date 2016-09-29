using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Countryregion {
        public Countryregion() { }
        public virtual string Countryregioncode { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
