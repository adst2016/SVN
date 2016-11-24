using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Currency {
        public Currency() { }
        public virtual string CurrencyCode { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
