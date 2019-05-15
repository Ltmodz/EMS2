namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedIssueWithDataTypeInMaritalStateTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MaritalStates", "name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MaritalStates", "name", c => c.Int(nullable: false));
        }
    }
}
