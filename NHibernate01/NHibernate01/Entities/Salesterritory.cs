using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Salesterritory {
        public Salesterritory() { }
        public virtual int Territoryid { get; set; }
        public virtual Countryregion Countryregion { get; set; }
        public virtual string Name { get; set; }
        public virtual string Group { get; set; }
        public virtual decimal Salesytd { get; set; }
        public virtual decimal Saleslastyear { get; set; }
        public virtual decimal Costytd { get; set; }
        public virtual decimal Costlastyear { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
    }
}
