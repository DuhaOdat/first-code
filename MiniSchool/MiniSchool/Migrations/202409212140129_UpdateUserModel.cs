namespace MiniSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "FullName", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "FullName", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
