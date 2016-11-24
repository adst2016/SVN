using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class CreditCard {
        public CreditCard() { }
        public virtual int CreditCardId { get; set; }
        public virtual string CardType { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual byte ExpMonth { get; set; }
        public virtual short ExpYear { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
