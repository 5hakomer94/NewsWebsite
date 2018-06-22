namespace NewsSystem.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mediatitlepropperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("Media.Media", "Title", c => c.String());
            AddColumn("Media.Media", "MediaLibraryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Media.Media", "MediaLibraryId");
            DropColumn("Media.Media", "Title");
        }
    }
}
