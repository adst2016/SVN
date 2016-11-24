using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class EmployeePayHistory {
        public virtual int BusinessEntityId { get; set; }
        public virtual DateTime RateChangeDate { get; set; }
        public virtual Employee FkEmployeePayHistoryEmployeeBusinessEntityId { get; set; }
        public virtual decimal Rate { get; set; }
        public virtual byte PayFrequency { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as EmployeePayHistory;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && RateChangeDate == t.RateChangeDate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ RateChangeDate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
