namespace NewsSystem.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "news.Tags", newName: "NewsTags");
            MoveTable(name: "dbo.EventTags", newSchema: "Event");
            AlterColumn("User.Users", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("User.Users", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("User.Users", "LastName", c => c.String(maxLength: 50));
            AlterColumn("User.Users", "FirstName", c => c.String(maxLength: 50));
            MoveTable(name: "Event.EventTags", newSchema: "dbo");
            RenameTable(name: "news.NewsTags", newName: "Tags");
        }
    }
}
