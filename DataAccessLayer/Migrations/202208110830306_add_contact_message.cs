namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_contact_message : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Message", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Message");
        }
    }
}
