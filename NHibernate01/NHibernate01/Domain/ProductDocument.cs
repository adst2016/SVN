using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductDocument {
        public virtual int ProductId { get; set; }
        public virtual string DocumentNode { get; set; }
        public virtual Product FkProductDocumentProductProductId { get; set; }
        public virtual Document FkProductDocumentDocumentDocumentNode { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductDocument;
			if (t == null) return false;
			if (ProductId == t.ProductId
			 && DocumentNode == t.DocumentNode)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();
			hash = (hash * 397) ^ DocumentNode.GetHashCode();

			return hash;
        }
        #endregion
    }
}
