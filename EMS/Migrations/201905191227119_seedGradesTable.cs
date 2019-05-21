namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedGradesTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Grades (name) values(N'ممتاز')");
            Sql("insert into Grades (name) values(N'جيد جدا')");
            Sql("insert into Grades (name) values(N'جيد')");
            Sql("insert into Grades (name) values(N'مقبول')");
            Sql("insert into Grades (name) values(N'ضعيف')");
        }
        
        public override void Down()
        {
        }
    }
}
