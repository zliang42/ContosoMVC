namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_OfficeInstructor : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.OfficeAssignments");
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.OfficeAssignments", "InstructorId");
            CreateIndex("dbo.OfficeAssignments", "InstructorId");
            AddForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorId" });
            DropPrimaryKey("dbo.OfficeAssignments");
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.OfficeAssignments", "InstructorId");
        }
    }
}
