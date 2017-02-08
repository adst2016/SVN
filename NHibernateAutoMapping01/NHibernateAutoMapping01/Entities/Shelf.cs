using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateAutoMapping01.Entities
{
    public class Shelf : Entity
    {
        public virtual int Id { get; set; }
        public virtual IList<Product> Products { get; set;}

        public Shelf()
        {
            Products = new List<Product>();
        }
    }
}
