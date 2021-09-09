namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        CountryCode = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(maxLength: 255),
                        FirstName = c.String(maxLength: 255),
                        EmailAdress = c.String(maxLength: 255),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "CountryId", "dbo.Countries");
            DropIndex("dbo.People", new[] { "CountryId" });
            DropTable("dbo.People");
            DropTable("dbo.Countries");
        }
    }
}
