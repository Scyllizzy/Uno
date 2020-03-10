namespace Uno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayers1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Win", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "Loss", c => c.Int(nullable: false));
            DropColumn("dbo.Players", "WinLossRatio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "WinLossRatio", c => c.Double());
            AlterColumn("dbo.Players", "Loss", c => c.Int());
            AlterColumn("dbo.Players", "Win", c => c.Int());
        }
    }
}
