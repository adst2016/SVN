using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class TransactionHistory {
        public virtual int TransactionId { get; set; }
        public virtual Product FkTransactionHistoryProductProductId { get; set; }
        public virtual int ReferenceOrderId { get; set; }
        public virtual int ReferenceOrderLineId { get; set; }
        public virtual DateTime TransactionDate { get; set; }
        public virtual string TransactionType { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal ActualCost { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
