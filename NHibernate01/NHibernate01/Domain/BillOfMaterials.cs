using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class BillOfMaterials {
        public virtual int BillOfMaterialsId { get; set; }
        public virtual Product FkBillOfMaterialsProductProductAssemblyId { get; set; }
        public virtual Product FkBillOfMaterialsProductComponentId { get; set; }
        public virtual UnitMeasure FkBillOfMaterialsUnitMeasureUnitMeasureCode { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual short BomLevel { get; set; }
        public virtual decimal PerAssemblyQty { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
