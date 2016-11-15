using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

using FluentNHibernate;


namespace NHibernate01
{
    public class Class1
    {
        public void GetID()
        {
            var cfg = new Configuration();
            cfg.Configure();

            //var sessionFactory = cfg.BuildSessionFactory();

            //var cfgFluently = FluentNHibernate.Cfg.Fluently.Configure(cfg).Mappings(m => m.FluentMappings.AddFromAssemblyOf<PersonMap>());


            //var sessionFactory = cfgFluently.BuildSessionFactory();

            //ISession session = sessionFactory.OpenSession();

            //var person = session.Get<Person>(1);

        }

    }
}
