using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class BusinessEntityAddress {
        public virtual int BusinessEntityId { get; set; }
        public virtual int AddressId { get; set; }
        public virtual int AddressTypeId { get; set; }
        public virtual BusinessEntity FkBusinessEntityAddressBusinessEntityBusinessEntityId { get; set; }
        public virtual Address FkBusinessEntityAddressAddressAddressId { get; set; }
        public virtual AddressType FkBusinessEntityAddressAddressTypeAddressTypeId { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as BusinessEntityAddress;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && AddressId == t.AddressId
			 && AddressTypeId == t.AddressTypeId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ AddressId.GetHashCode();
			hash = (hash * 397) ^ AddressTypeId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
