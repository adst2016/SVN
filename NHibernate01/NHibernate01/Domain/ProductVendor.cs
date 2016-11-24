using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductVendor {
        public virtual int ProductId { get; set; }
        public virtual int BusinessEntityId { get; set; }
        public virtual Product FkProductVendorProductProductId { get; set; }
        public virtual Vendor FkProductVendorVendorBusinessEntityId { get; set; }
        public virtual UnitMeasure FkProductVendorUnitMeasureUnitMeasureCode { get; set; }
        public virtual int AverageLeadTime { get; set; }
        public virtual decimal StandardPrice { get; set; }
        public virtual decimal? LastReceiptCost { get; set; }
        public virtual DateTime? LastReceiptDate { get; set; }
        public virtual int MinOrderQty { get; set; }
        public virtual int MaxOrderQty { get; set; }
        public virtual int? OnOrderQty { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductVendor;
			if (t == null) return false;
			if (ProductId == t.ProductId
			 && BusinessEntityId == t.BusinessEntityId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
