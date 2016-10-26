namespace S00156762Week6.Migration.AutenticationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StudentID", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StudentID");
        }
    }
}
