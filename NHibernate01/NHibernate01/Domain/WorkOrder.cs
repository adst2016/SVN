using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class WorkOrder {
        public WorkOrder() { }
        public virtual int WorkOrderId { get; set; }
        public virtual Product FkWorkOrderProductProductId { get; set; }
        public virtual ScrapReason FkWorkOrderScrapReasonScrapReasonId { get; set; }
        public virtual int OrderQty { get; set; }
        public virtual int StockedQty { get; set; }
        public virtual short ScrappedQty { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
