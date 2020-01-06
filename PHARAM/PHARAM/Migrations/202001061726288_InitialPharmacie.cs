namespace PHARAM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialPharmacie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pharmacies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        MotPasse = c.String(),
                        Longitude = c.String(),
                        Latitude = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pharmacies");
        }
    }
}
