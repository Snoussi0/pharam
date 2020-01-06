namespace PHARAM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pharmacies", "Nuit", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pharmacies", "Nom", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pharmacies", "Nom");
            DropColumn("dbo.Pharmacies", "Nuit");
        }
    }
}
