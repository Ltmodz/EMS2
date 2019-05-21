namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTrainigsToEmployes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "employeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Trainings", "employeId");
            AddForeignKey("dbo.Trainings", "employeId", "dbo.Employes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainings", "employeId", "dbo.Employes");
            DropIndex("dbo.Trainings", new[] { "employeId" });
            DropColumn("dbo.Trainings", "employeId");
        }
    }
}
