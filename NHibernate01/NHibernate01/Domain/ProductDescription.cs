using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductDescription {
        public ProductDescription() { }
        public virtual int ProductDescriptionId { get; set; }
        public virtual string Description { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
