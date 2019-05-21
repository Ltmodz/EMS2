namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedResultsTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Results (name) values(N'ناجح')");
            Sql("insert into Results (name) values(N' راسب')");

        }
        
        public override void Down()
        {
        }
    }
}
