using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using NHibernateAutoMapping01.Entities;

namespace NHibernateAutoMapping01
{
    public class FluentConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            //return type.Namespace == "NHibernateAutoMapping01.Entities";
            return typeof(Entity).IsAssignableFrom(type);
        }

        public override bool IsComponent(Type type)
        {
            return type == typeof(Address);
        }
    }
}
