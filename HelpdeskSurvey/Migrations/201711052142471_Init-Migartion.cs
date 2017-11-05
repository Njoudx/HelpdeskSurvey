namespace HelpdeskSurvey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigartion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AljUser = c.String(),
                        ComputerType = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
