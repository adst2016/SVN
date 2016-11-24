using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductSubcategory {
        public ProductSubcategory() { }
        public virtual int ProductSubcategoryId { get; set; }
        public virtual ProductCategory FkProductSubcategoryProductCategoryProductCategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
