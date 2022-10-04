namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class about : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutDetails1", c => c.String(maxLength: 500));
            DropColumn("dbo.Abouts", "AboutDetails");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutDetails", c => c.String(maxLength: 500));
            DropColumn("dbo.Abouts", "AboutDetails1");
        }
    }
}
