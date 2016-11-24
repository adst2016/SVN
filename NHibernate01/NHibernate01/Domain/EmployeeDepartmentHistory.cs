using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class EmployeeDepartmentHistory {
        public virtual int BusinessEntityId { get; set; }
        public virtual short DepartmentId { get; set; }
        public virtual byte ShiftId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual Employee FkEmployeeDepartmentHistoryEmployeeBusinessEntityId { get; set; }
        public virtual Department FkEmployeeDepartmentHistoryDepartmentDepartmentId { get; set; }
        public virtual Shift FkEmployeeDepartmentHistoryShiftShiftId { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as EmployeeDepartmentHistory;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && DepartmentId == t.DepartmentId
			 && ShiftId == t.ShiftId
			 && StartDate == t.StartDate)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ DepartmentId.GetHashCode();
			hash = (hash * 397) ^ ShiftId.GetHashCode();
			hash = (hash * 397) ^ StartDate.GetHashCode();

			return hash;
        }
        #endregion
    }
}
