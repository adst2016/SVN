using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductInventory {
        public virtual int ProductId { get; set; }
        public virtual short LocationId { get; set; }
        public virtual Product FkProductInventoryProductProductId { get; set; }
        public virtual Location FkProductInventoryLocationLocationId { get; set; }
        public virtual string Shelf { get; set; }
        public virtual byte Bin { get; set; }
        public virtual short Quantity { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductInventory;
			if (t == null) return false;
			if (ProductId == t.ProductId
			 && LocationId == t.LocationId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();
			hash = (hash * 397) ^ LocationId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
