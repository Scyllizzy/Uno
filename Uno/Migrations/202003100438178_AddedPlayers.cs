namespace Uno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "FirstName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Players", "LastName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Players", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Players", "WinLossRatio", c => c.Double());
            AlterColumn("dbo.Players", "UserName", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.Players", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Password", c => c.String());
            AlterColumn("dbo.Players", "UserName", c => c.String());
            AlterColumn("dbo.Players", "WinLossRatio", c => c.Double(nullable: false));
            AlterColumn("dbo.Players", "Email", c => c.String());
            AlterColumn("dbo.Players", "LastName", c => c.String());
            AlterColumn("dbo.Players", "FirstName", c => c.String());
        }
    }
}
