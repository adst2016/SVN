using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Employee {
        public Employee() { }
        public virtual int BusinessEntityId { get; set; }
        public virtual Person FkEmployeePersonBusinessEntityId { get; set; }
        public virtual string NationalIdNumber { get; set; }
        public virtual string LoginId { get; set; }
        public virtual string OrganizationNode { get; set; }
        public virtual short? OrganizationLevel { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string MaritalStatus { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual bool SalariedFlag { get; set; }
        public virtual short VacationHours { get; set; }
        public virtual short SickLeaveHours { get; set; }
        public virtual bool CurrentFlag { get; set; }
        public virtual System.Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
