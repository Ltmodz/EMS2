namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmployeDataToDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        phoneNumber = c.String(nullable: false, maxLength: 11),
                        address = c.String(nullable: false),
                        nationalID = c.String(nullable: false, maxLength: 14),
                        DOB = c.DateTime(nullable: false),
                        contractionDate = c.DateTime(nullable: false),
                        disablity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employes");
        }
    }
}
