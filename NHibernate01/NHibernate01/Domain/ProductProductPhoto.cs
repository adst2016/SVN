using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductProductPhoto {
        public virtual int ProductId { get; set; }
        public virtual int ProductPhotoId { get; set; }
        public virtual Product FkProductProductPhotoProductProductId { get; set; }
        public virtual ProductPhoto FkProductProductPhotoProductPhotoProductPhotoId { get; set; }
        public virtual bool Primary { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductProductPhoto;
			if (t == null) return false;
			if (ProductId == t.ProductId
			 && ProductPhotoId == t.ProductPhotoId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();
			hash = (hash * 397) ^ ProductPhotoId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
