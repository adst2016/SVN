using System;
using FluentNHibernate.Automapping;
using NHibernateAutoMapping01.Entities;

namespace NHibernateAutoMapping01
{
    public class FluentConfiguration2 : DefaultAutomappingConfiguration
    {
        public override bool IsComponent(Type type)
        {
            return type == typeof(Address);
        }
    }
}
