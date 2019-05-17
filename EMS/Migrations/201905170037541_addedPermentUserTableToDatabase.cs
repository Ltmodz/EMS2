namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPermentUserTableToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PermenentUsers",
                c => new
                    {
                        id = c.Int(nullable: false),
                        jobName = c.String(nullable: false),
                        qualification = c.String(nullable: false),
                        fileNumber = c.Int(nullable: false),
                        installmentNumber = c.Int(nullable: false),
                        installmentDate = c.DateTime(nullable: false),
                        preRankDate = c.DateTime(nullable: false),
                        currentRankDate = c.DateTime(nullable: false),
                        jobGroupId = c.Int(nullable: false),
                        jobDegreeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employes", t => t.id)
                .ForeignKey("dbo.JobDegrees", t => t.jobDegreeId, cascadeDelete: true)
                .ForeignKey("dbo.JobGroups", t => t.jobGroupId, cascadeDelete: true)
                .Index(t => t.id)
                .Index(t => t.jobGroupId)
                .Index(t => t.jobDegreeId);
            
            AddColumn("dbo.Employes", "permenentUserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PermenentUsers", "jobGroupId", "dbo.JobGroups");
            DropForeignKey("dbo.PermenentUsers", "jobDegreeId", "dbo.JobDegrees");
            DropForeignKey("dbo.PermenentUsers", "id", "dbo.Employes");
            DropIndex("dbo.PermenentUsers", new[] { "jobDegreeId" });
            DropIndex("dbo.PermenentUsers", new[] { "jobGroupId" });
            DropIndex("dbo.PermenentUsers", new[] { "id" });
            DropColumn("dbo.Employes", "permenentUserId");
            DropTable("dbo.PermenentUsers");
        }
    }
}
