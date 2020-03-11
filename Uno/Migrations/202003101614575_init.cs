namespace Uno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false),
                        Win = c.Int(nullable: false),
                        Loss = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.PlayerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
