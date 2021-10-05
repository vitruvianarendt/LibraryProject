namespace LibraryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class details : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Copies", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Copies");
            DropColumn("dbo.Books", "Price");
        }
    }
}
