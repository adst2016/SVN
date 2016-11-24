using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SpecialOffer {
        public SpecialOffer() { }
        public virtual int SpecialOfferId { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal DiscountPct { get; set; }
        public virtual string Type { get; set; }
        public virtual string Category { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual int MinQty { get; set; }
        public virtual int? MaxQty { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
