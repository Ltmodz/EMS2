namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedJobGroupsTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into JobGroups (name) values(N'التخصصية')");
            Sql("insert into JobGroups (name) values(N'الكتابية')");
            Sql("insert into JobGroups (name) values(N'الفنية')");
            Sql("insert into JobGroups (name) values(N'الحرفية')");
            Sql("insert into JobGroups (name) values(N'خدمة معاونة')");

        }
        
        public override void Down()
        {
        }
    }
}
