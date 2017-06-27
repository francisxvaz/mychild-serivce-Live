namespace MyChild.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBlogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Body = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                        SubHeader = c.String(),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Blogs", new[] { "Author_Id" });
            DropTable("dbo.Blogs");
        }
    }
}
