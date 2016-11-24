using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesOrderHeaderSalesReason {
        public virtual int SalesOrderId { get; set; }
        public virtual int SalesReasonId { get; set; }
        public virtual SalesOrderHeader FkSalesOrderHeaderSalesReasonSalesOrderHeaderSalesOrderId { get; set; }
        public virtual SalesReason FkSalesOrderHeaderSalesReasonSalesReasonSalesReasonId { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as SalesOrderHeaderSalesReason;
			if (t == null) return false;
			if (SalesOrderId == t.SalesOrderId
			 && SalesReasonId == t.SalesReasonId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ SalesOrderId.GetHashCode();
			hash = (hash * 397) ^ SalesReasonId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
