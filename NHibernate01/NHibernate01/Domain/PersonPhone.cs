using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class PersonPhone {
        public virtual int BusinessEntityId { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual int PhoneNumberTypeId { get; set; }
        public virtual Person FkPersonPhonePersonBusinessEntityId { get; set; }
        public virtual PhoneNumberType FkPersonPhonePhoneNumberTypePhoneNumberTypeId { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as PersonPhone;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && PhoneNumber == t.PhoneNumber
			 && PhoneNumberTypeId == t.PhoneNumberTypeId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ PhoneNumber.GetHashCode();
			hash = (hash * 397) ^ PhoneNumberTypeId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
