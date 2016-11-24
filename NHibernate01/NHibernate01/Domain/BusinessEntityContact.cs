using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class BusinessEntityContact {
        public virtual int BusinessEntityId { get; set; }
        public virtual int PersonId { get; set; }
        public virtual int ContactTypeId { get; set; }
        public virtual BusinessEntity FkBusinessEntityContactBusinessEntityBusinessEntityId { get; set; }
        public virtual Person FkBusinessEntityContactPersonPersonId { get; set; }
        public virtual ContactType FkBusinessEntityContactContactTypeContactTypeId { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as BusinessEntityContact;
			if (t == null) return false;
			if (BusinessEntityId == t.BusinessEntityId
			 && PersonId == t.PersonId
			 && ContactTypeId == t.ContactTypeId)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ BusinessEntityId.GetHashCode();
			hash = (hash * 397) ^ PersonId.GetHashCode();
			hash = (hash * 397) ^ ContactTypeId.GetHashCode();

			return hash;
        }
        #endregion
    }
}
