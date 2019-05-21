namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTraningsTablesToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        organization = c.String(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        resultId = c.Int(nullable: false),
                        gradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Grades", t => t.gradeId, cascadeDelete: true)
                .ForeignKey("dbo.Results", t => t.resultId, cascadeDelete: true)
                .Index(t => t.resultId)
                .Index(t => t.gradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainings", "resultId", "dbo.Results");
            DropForeignKey("dbo.Trainings", "gradeId", "dbo.Grades");
            DropIndex("dbo.Trainings", new[] { "gradeId" });
            DropIndex("dbo.Trainings", new[] { "resultId" });
            DropTable("dbo.Trainings");
        }
    }
}
