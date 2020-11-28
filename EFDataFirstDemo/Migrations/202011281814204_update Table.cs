namespace EFDataFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "UserName", c => c.Int(nullable: false));
        }
    }
}
