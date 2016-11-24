using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Document {
        public Document() { }
        public virtual string DocumentNode { get; set; }
        public virtual Employee FkDocumentEmployeeOwner { get; set; }
        public virtual short? DocumentLevel { get; set; }
        public virtual string Title { get; set; }
        public virtual bool FolderFlag { get; set; }
        public virtual string FileName { get; set; }
        public virtual string FileExtension { get; set; }
        public virtual string Revision { get; set; }
        public virtual int ChangeNumber { get; set; }
        public virtual byte Status { get; set; }
        public virtual string DocumentSummary { get; set; }
        public virtual byte[] DocumentBin { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
