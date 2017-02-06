using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Automapping;
using NHibernateAutoMapping01.Entities;
using FluentNHibernate.Cfg.Db;

namespace NHibernateAutoMapping01
{
    public class Class1
    {
        public void CreateDataBase()
        {
            var cfg = new Configuration();            
            cfg.Configure();
            
            var cfg2 = new FluentConfiguration();
            
            var sessionFactory = Fluently.Configure(cfg)
                .Mappings(m =>
                m.AutoMappings
                .Add(AutoMap.AssemblyOf<Product>(cfg2)
                ))                 
                .BuildSessionFactory();


        }
    }
}
