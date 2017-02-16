using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateAutoMapping01.Entities
{
    public class Computer : Entity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual IList<Monitor> Monitors { get; set; }

        public Computer()
        {
            Monitors = new List<Monitor>();
        }
    }
}
