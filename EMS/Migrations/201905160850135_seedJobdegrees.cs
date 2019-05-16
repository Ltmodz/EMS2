namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedJobdegrees : DbMigration
    {
        public override void Up()
        {
            Sql("insert into JobDegrees (name) values(N'الاولة')");
            Sql("insert into JobDegrees (name) values(N'الثانية')");
            Sql("insert into JobDegrees (name) values(N'الثالثة')");
            Sql("insert into JobDegrees (name) values(N'الرابعة')");
            Sql("insert into JobDegrees (name) values(N'الخامسة')");
            Sql("insert into JobDegrees (name) values(N'السادسة')");
            Sql("insert into JobDegrees (name) values(N'مدير عام')");
        }
        
        public override void Down()
        {
        }
    }
}
