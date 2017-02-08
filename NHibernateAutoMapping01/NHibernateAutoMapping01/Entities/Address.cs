using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateAutoMapping01.Entities
{
    public class Address : Entity
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
