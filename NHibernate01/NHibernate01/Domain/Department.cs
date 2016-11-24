using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class Department {
        public Department() { }
        public virtual short DepartmentId { get; set; }
        public virtual string Name { get; set; }
        public virtual string GroupName { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
