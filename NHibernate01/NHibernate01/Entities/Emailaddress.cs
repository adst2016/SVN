using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Emailaddress {
        public virtual int Businessentityid { get; set; }
        public virtual int Emailaddressid { get; set; }
        public virtual Person Person { get; set; }
        public virtual string EmailaddressVal { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime Modifieddate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Emailaddress;
			if (t == null) return false;
			if (Businessentityid == t.Businessentityid
			 && Emailaddressid == t.Emailaddressid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Emailaddressid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
