using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductModelIllustration {
        public virtual int ProductModelId { get; set; }
        public virtual int IllustrationId { get; set; }
        public virtual ProductModel FkProductModelIllustrationProductModelProductModelId { get; set; }
        public virtual Illustration FkProductModelIllustrationIllustrationIllustrationId { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductModelIllustration;
			if (t == null) return false;
			if (ProductModelId == t.ProductModelId
			 && IllustrationId == t.IllustrationId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductModelId.GetHashCode();
			hash = (hash * 397) ^ IllustrationId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
