using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductCostHistory {
        public virtual int ProductId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual Product FkProductCostHistoryProductProductId { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual decimal StandardCost { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ProductCostHistory;
			if (t == null) return false;
			if (ProductId == t.ProductId
			 && StartDate == t.StartDate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();
			hash = (hash * 397) ^ StartDate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
