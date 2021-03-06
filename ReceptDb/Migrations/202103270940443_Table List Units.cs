namespace ReceptDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableListUnits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListUnits");
        }
    }
}
