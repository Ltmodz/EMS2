namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedMaritalStates : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MaritalStates (name) values(N'اعزب')");
            Sql("insert into MaritalStates (name) values(N'انسة')");
            Sql("insert into MaritalStates (name) values(N'متزوج')");
            Sql("insert into MaritalStates (name) values(N'متزوجة')");
            Sql("insert into MaritalStates (name) values(N'مطلق')");
            Sql("insert into MaritalStates (name) values(N'مطلقة')");
            Sql("insert into MaritalStates (name) values(N'ارمل')");
            Sql("insert into MaritalStates (name) values(N'ارملة')");
        }
        
        public override void Down()
        {
        }
    }
}
