using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class PersonCreditCard {
        public virtual int BusinessEntityId { get; set; }
        public virtual int CreditCardId { get; set; }
        public virtual Person FkPersonCreditCardPersonBusinessEntityId { get; set; }
        public virtual CreditCard FkPersonCreditCardCreditCardCreditCardId { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as PersonCreditCard;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && CreditCardId == t.CreditCardId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ CreditCardId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
