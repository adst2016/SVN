using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class WorkOrderRouting {
        public virtual int WorkOrderId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual short OperationSequence { get; set; }
        public virtual WorkOrder FkWorkOrderRoutingWorkOrderWorkOrderId { get; set; }
        public virtual Location FkWorkOrderRoutingLocationLocationId { get; set; }
        public virtual DateTime ScheduledStartDate { get; set; }
        public virtual DateTime ScheduledEndDate { get; set; }
        public virtual DateTime? ActualStartDate { get; set; }
        public virtual DateTime? ActualEndDate { get; set; }
        public virtual decimal? ActualResourceHrs { get; set; }
        public virtual decimal PlannedCost { get; set; }
        public virtual decimal? ActualCost { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as WorkOrderRouting;
			if (t == null) return false;
			if (WorkOrderId == t.WorkOrderId
			 && ProductId == t.ProductId
			 && OperationSequence == t.OperationSequence)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ WorkOrderId.GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();
			hash = (hash * 397) ^ OperationSequence.GetHashCode();

			return hash;
        }
        #endregion
    }
}
