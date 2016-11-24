using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductModel {
        public ProductModel() { }
        public virtual int ProductModelId { get; set; }
        public virtual string Name { get; set; }
        public virtual string CatalogDescription { get; set; }
        public virtual string Instructions { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
