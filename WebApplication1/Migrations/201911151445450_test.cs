namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tournois",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Tournoi_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Tournois", t => t.Tournoi_id)
                .Index(t => t.Tournoi_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Tournoi_id", "dbo.Tournois");
            DropIndex("dbo.Users", new[] { "Tournoi_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Tournois");
        }
    }
}
