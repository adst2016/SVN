using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateAutoMapping01.Entities
{
    public class Monitor : Entity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual IList<Computer> Computers { get; set; }

        public Monitor()
        {
            Computers = new List<Computer>();
        }
    }
}
