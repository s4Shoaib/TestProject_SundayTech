namespace SundayTechTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EnrollmentDate = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        City = c.String(maxLength: 50),
                        PostalCode = c.String(maxLength: 10),
                        Age = c.String(maxLength: 2),
                        EmailAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
