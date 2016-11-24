using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductReview {
        public virtual int ProductReviewId { get; set; }
        public virtual Product FkProductReviewProductProductId { get; set; }
        public virtual string ReviewerName { get; set; }
        public virtual DateTime ReviewDate { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual int Rating { get; set; }
        public virtual string Comments { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
