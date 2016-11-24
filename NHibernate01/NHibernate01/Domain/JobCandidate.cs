using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class JobCandidate {
        public virtual int JobCandidateId { get; set; }
        public virtual Employee FkJobCandidateEmployeeBusinessEntityId { get; set; }
        public virtual string Resume { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
