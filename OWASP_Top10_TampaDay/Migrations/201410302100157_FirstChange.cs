namespace OWASP_Top10_TampaDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                        ApplicationUserId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId_Id)
                .Index(t => t.ApplicationUserId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "ApplicationUserId_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "ApplicationUserId_Id" });
            DropTable("dbo.Comments");
        }
    }
}
