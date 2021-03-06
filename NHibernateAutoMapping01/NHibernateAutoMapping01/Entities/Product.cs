﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateAutoMapping01.Entities
{
    public class Product : Entity
    {
        public virtual int Id { get; set;}
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal VAT { get; set; }

        public Monitor Monitor { get; set; }
    }
}
