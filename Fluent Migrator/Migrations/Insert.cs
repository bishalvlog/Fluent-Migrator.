using FluentMigrator;

namespace Fluent_Migrator_.Migrations
{
    [Migration(12345)]
    public class Insert : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Execute.Sql("SET IDENTITY_INSERT [dbo].[Address] ON");
            Insert.IntoTable("Address").Row(new { Id = 1, Street = "chakhuoat", City = "ktm", State = "lalitpur", Zip = "213" });
        }
    }
}
