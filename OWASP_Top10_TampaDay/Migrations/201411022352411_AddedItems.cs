namespace OWASP_Top10_TampaDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Abstract = c.String(maxLength: 1024),
                        Detail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
