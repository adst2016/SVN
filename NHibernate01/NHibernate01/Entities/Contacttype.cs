using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Contacttype {
        public Contacttype() { }
        public virtual int Contacttypeid { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
