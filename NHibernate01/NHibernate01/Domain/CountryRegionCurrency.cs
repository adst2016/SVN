using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class CountryRegionCurrency {
        public virtual string CountryRegionCode { get; set; }
        public virtual string CurrencyCode { get; set; }
        public virtual CountryRegion FkCountryRegionCurrencyCountryRegionCountryRegionCode { get; set; }
        public virtual Currency FkCountryRegionCurrencyCurrencyCurrencyCode { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as CountryRegionCurrency;
			if (t == null) return false;
			if (CountryRegionCode == t.CountryRegionCode
			 && CurrencyCode == t.CurrencyCode)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ CountryRegionCode.GetHashCode();
			hash = (hash * 397) ^ CurrencyCode.GetHashCode();

			return hash;
        }
        #endregion
    }
}
