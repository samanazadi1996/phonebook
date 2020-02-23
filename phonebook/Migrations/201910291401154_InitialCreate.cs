namespace phonebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.pbs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fname = c.Int(nullable: false),
                        lname = c.Int(nullable: false),
                        pnumber = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.pbs");
        }
    }
}
