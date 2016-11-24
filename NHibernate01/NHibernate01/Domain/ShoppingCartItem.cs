using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ShoppingCartItem {
        public virtual int ShoppingCartItemId { get; set; }
        public virtual Product FkShoppingCartItemProductProductId { get; set; }
        public virtual string ShoppingCartId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
