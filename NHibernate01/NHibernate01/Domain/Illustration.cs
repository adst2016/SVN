using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Illustration {
        public Illustration() { }
        public virtual int IllustrationId { get; set; }
        public virtual string Diagram { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
