namespace MyChild.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAuthortable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Authors");
        }
    }
}
