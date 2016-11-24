using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class ProductPhoto {
        public ProductPhoto() { }
        public virtual int ProductPhotoId { get; set; }
        public virtual byte[] ThumbNailPhoto { get; set; }
        public virtual string ThumbnailPhotoFileName { get; set; }
        public virtual byte[] LargePhoto { get; set; }
        public virtual string LargePhotoFileName { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
