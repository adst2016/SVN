using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductModelProductDescriptionCulture {
        public virtual int ProductModelId { get; set; }
        public virtual int ProductDescriptionId { get; set; }
        public virtual string CultureId { get; set; }
        public virtual ProductModel FkProductModelProductDescriptionCultureProductModelProductModelId { get; set; }
        public virtual ProductDescription FkProductModelProductDescriptionCultureProductDescriptionProductDescriptionId { get; set; }
        public virtual Culture FkProductModelProductDescriptionCultureCultureCultureId { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductModelProductDescriptionCulture;
			if (t == null) return false;
			if (ProductModelId == t.ProductModelId
			 && ProductDescriptionId == t.ProductDescriptionId
			 && CultureId == t.CultureId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductModelId.GetHashCode();
			hash = (hash * 397) ^ ProductDescriptionId.GetHashCode();
			hash = (hash * 397) ^ CultureId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
