using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using FluentMigrator.Infrastructure;

namespace NHibernateAutoMapping01
{
    [Migration(1)]
    public class PlatformMigration : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Alter.Column("Shelf_id").OnTable("Product").AsInt32().NotNullable();

            Create.Index("index001").OnTable("Product").OnColumn("Shelf_id").Ascending();

        }
    }

    [Migration(2)]
    public class PlatformMigration2 : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Insert.IntoTable("Person").Row(new { Name = "adam", AddressNumber = "22", AddressStreet = "oswiecenia", AddressPostCode = "22-290" });
        }
    }
}
