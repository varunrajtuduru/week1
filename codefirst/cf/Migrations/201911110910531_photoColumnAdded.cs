namespace cf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photoColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "photo");
        }
    }
}
