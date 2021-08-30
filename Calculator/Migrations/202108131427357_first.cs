namespace Calculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calcs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        input1 = c.String(),
                        input2 = c.String(),
                        arithmetic = c.String(),
                        result = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Calcs");
        }
    }
}
