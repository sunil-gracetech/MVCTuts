namespace MVCTuts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Department_Id", c => c.Int());
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
            CreateIndex("dbo.Employees", "Department_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropColumn("dbo.Employees", "Department_Id");
            DropTable("dbo.Departments");
        }
    }
}
