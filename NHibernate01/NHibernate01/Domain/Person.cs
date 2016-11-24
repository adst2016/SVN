using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Person {
        public Person() { }
        public virtual int BusinessEntityId { get; set; }
        public virtual BusinessEntity FkPersonBusinessEntityBusinessEntityId { get; set; }
        public virtual string PersonType { get; set; }
        public virtual bool NameStyle { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual int EmailPromotion { get; set; }
        public virtual string AdditionalContactInfo { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
