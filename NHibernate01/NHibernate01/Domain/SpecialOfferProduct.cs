using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SpecialOfferProduct {
        public SpecialOfferProduct() { }
        public virtual int SpecialOfferId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual SpecialOffer FkSpecialOfferProductSpecialOfferSpecialOfferId { get; set; }
        public virtual Product FkSpecialOfferProductProductProductId { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as SpecialOfferProduct;
			if (t == null) return false;
			if (SpecialOfferId == t.SpecialOfferId
			 && ProductId == t.ProductId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ SpecialOfferId.GetHashCode();
			hash = (hash * 397) ^ ProductId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
