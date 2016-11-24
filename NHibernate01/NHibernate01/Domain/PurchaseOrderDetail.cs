using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class PurchaseOrderDetail {
        public virtual int PurchaseOrderId { get; set; }
        public virtual int PurchaseOrderDetailId { get; set; }
        public virtual PurchaseOrderHeader FkPurchaseOrderDetailPurchaseOrderHeaderPurchaseOrderId { get; set; }
        public virtual Product FkPurchaseOrderDetailProductProductId { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual short OrderQty { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal LineTotal { get; set; }
        public virtual decimal ReceivedQty { get; set; }
        public virtual decimal RejectedQty { get; set; }
        public virtual decimal StockedQty { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as PurchaseOrderDetail;
			if (t == null) return false;
			if (PurchaseOrderId == t.PurchaseOrderId
			 && PurchaseOrderDetailId == t.PurchaseOrderDetailId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ PurchaseOrderId.GetHashCode();
			hash = (hash * 397) ^ PurchaseOrderDetailId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
