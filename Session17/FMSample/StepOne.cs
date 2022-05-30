using System;
using FluentMigrator;

namespace FMSample
{
    [Migration(1)]
    public class StepOne : Migration
    {
        public override void Up()
        {
            Create.Table("Students")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Firstname").AsString(256).Nullable()
                .WithColumn("Lastname").AsString(256).Nullable();
        }

        public override void Down()
        {
        }
    }
}
