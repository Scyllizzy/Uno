namespace Uno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Win = c.Int(nullable: false),
                        Loss = c.Int(nullable: false),
                        WinLossRatio = c.Double(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.PlayerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
