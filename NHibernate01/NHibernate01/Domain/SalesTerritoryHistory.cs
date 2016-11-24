using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesTerritoryHistory {
        public virtual int BusinessEntityId { get; set; }
        public virtual int TerritoryId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual SalesPerson FkSalesTerritoryHistorySalesPersonBusinessEntityId { get; set; }
        public virtual SalesTerritory FkSalesTerritoryHistorySalesTerritoryTerritoryId { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as SalesTerritoryHistory;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && TerritoryId == t.TerritoryId
			 && StartDate == t.StartDate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ TerritoryId.GetHashCode();
			hash = (hash * 397) ^ StartDate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
