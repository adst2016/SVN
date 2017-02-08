using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Automapping;
using NHibernateAutoMapping01.Entities;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Conventions.Helpers;

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
                .Conventions.Add(PrimaryKey.Name.Is(x => "Id"))
                ))
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();

            //var exporter = new SchemaExport(cfg);
            //exporter.Execute(true, true, false);

            //var updater = new SchemaUpdate(cfg);
            //updater.Execute(true, true);
        }

        public void CreateDataBase2()
        {
            var cfg = new Configuration();
            cfg.Configure();

            //var cfg2 = new FluentConfiguration2();

            var autoMap = AutoMap.AssemblyOf<Entity>()
            .Where(t => typeof(Entity).IsAssignableFrom(t));

            var sessionFactory = Fluently.Configure(cfg)
                .Mappings(m =>
                m.AutoMappings
                .Add(autoMap))
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
        }

        private void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(true, true);
        }
    }
}
