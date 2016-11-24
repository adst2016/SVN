using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class CountryRegion {
        public CountryRegion() { }
        public virtual string CountryRegionCode { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
