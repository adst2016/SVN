using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class SalesTaxRate {
        public virtual int SalesTaxRateId { get; set; }
        public virtual StateProvince FkSalesTaxRateStateProvinceStateProvinceId { get; set; }
        public virtual byte TaxType { get; set; }
        public virtual decimal TaxRate { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
