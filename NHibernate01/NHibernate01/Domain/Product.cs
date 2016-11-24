using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Product {
        public Product() { }
        public virtual int ProductId { get; set; }
        public virtual UnitMeasure FkProductUnitMeasureSizeUnitMeasureCode { get; set; }
        public virtual UnitMeasure FkProductUnitMeasureWeightUnitMeasureCode { get; set; }
        public virtual ProductSubcategory FkProductProductSubcategoryProductSubcategoryId { get; set; }
        public virtual ProductModel FkProductProductModelProductModelId { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProductNumber { get; set; }
        public virtual bool MakeFlag { get; set; }
        public virtual bool FinishedGoodsFlag { get; set; }
        public virtual string Color { get; set; }
        public virtual short SafetyStockLevel { get; set; }
        public virtual short ReorderPoint { get; set; }
        public virtual decimal StandardCost { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual string Size { get; set; }
        public virtual decimal? Weight { get; set; }
        public virtual int DaysToManufacture { get; set; }
        public virtual string ProductLine { get; set; }
        public virtual string Class { get; set; }
        public virtual string Style { get; set; }
        public virtual DateTime SellStartDate { get; set; }
        public virtual DateTime? SellEndDate { get; set; }
        public virtual DateTime? DiscontinuedDate { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
