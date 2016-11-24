using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesPersonQuotaHistory {
        public virtual int BusinessEntityId { get; set; }
        public virtual DateTime QuotaDate { get; set; }
        public virtual SalesPerson FkSalesPersonQuotaHistorySalesPersonBusinessEntityId { get; set; }
        public virtual decimal SalesQuota { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as SalesPersonQuotaHistory;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && QuotaDate == t.QuotaDate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ QuotaDate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
