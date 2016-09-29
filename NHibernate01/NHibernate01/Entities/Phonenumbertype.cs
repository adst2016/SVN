using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Phonenumbertype {
        public Phonenumbertype() { }
        public virtual int Phonenumbertypeid { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
