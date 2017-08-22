namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Junction_PersonRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RolePersons",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Person_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePersons", "Person_Id", "dbo.People");
            DropForeignKey("dbo.RolePersons", "Role_Id", "dbo.Roles");
            DropIndex("dbo.RolePersons", new[] { "Person_Id" });
            DropIndex("dbo.RolePersons", new[] { "Role_Id" });
            DropTable("dbo.RolePersons");
        }
    }
}
