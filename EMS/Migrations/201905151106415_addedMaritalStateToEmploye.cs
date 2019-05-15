namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMaritalStateToEmploye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "maritalStateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employes", "maritalStateId");
            AddForeignKey("dbo.Employes", "maritalStateId", "dbo.MaritalStates", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employes", "maritalStateId", "dbo.MaritalStates");
            DropIndex("dbo.Employes", new[] { "maritalStateId" });
            DropColumn("dbo.Employes", "maritalStateId");
        }
    }
}
