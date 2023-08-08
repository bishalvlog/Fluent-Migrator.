using FluentMigrator;

namespace Fluent_Migrator_.Migrations
{
    [Migration(123456)]
    public class Migration123456 : Migration
    {
        public override void Down()
        {
            Delete.Table("Address");
        }

        public override void Up()
        {
            Create.Table("Address")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Street").AsString().NotNullable()
                .WithColumn("City").AsString().NotNullable()
                .WithColumn("State").AsString().NotNullable()
                .WithColumn("Zip").AsString().Nullable();
        }

    }
}
