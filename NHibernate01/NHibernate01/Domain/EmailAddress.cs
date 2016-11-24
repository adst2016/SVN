using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class EmailAddress {
        public virtual int BusinessEntityId { get; set; }
        public virtual int EmailAddressId { get; set; }
        public virtual Person FkEmailAddressPersonBusinessEntityId { get; set; }
        public virtual string EmailAddressText { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as EmailAddress;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && EmailAddressId == t.EmailAddressId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ EmailAddressId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
