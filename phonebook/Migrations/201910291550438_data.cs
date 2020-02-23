namespace phonebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.pbs", "fname", c => c.String(nullable: false));
            AlterColumn("dbo.pbs", "lname", c => c.String(nullable: false));
            AlterColumn("dbo.pbs", "pnumber", c => c.String(nullable: false));
            AlterColumn("dbo.pbs", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.pbs", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.pbs", "pnumber", c => c.Int(nullable: false));
            AlterColumn("dbo.pbs", "lname", c => c.Int(nullable: false));
            AlterColumn("dbo.pbs", "fname", c => c.Int(nullable: false));
        }
    }
}
