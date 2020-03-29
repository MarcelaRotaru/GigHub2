namespace GigHub2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToGig1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Gigs", new[] { "GenreID" });
            CreateIndex("dbo.Gigs", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Gigs", new[] { "GenreId" });
            CreateIndex("dbo.Gigs", "GenreID");
        }
    }
}
