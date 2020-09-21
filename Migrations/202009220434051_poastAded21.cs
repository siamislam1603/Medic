namespace Medic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poastAded21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        post = c.String(),
                        postDate = c.DateTime(nullable: true),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
