namespace NewsSystem.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comment_Modified_Property : DbMigration
    {
        public override void Up()
        {
            DropColumn("Media.Media", "CreatedDate");
            DropColumn("Media.Media", "LastModified");
        }
        
        public override void Down()
        {
            AddColumn("Media.Media", "LastModified", c => c.DateTime(nullable: false));
            AddColumn("Media.Media", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
