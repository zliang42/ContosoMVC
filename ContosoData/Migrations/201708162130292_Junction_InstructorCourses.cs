namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Junction_InstructorCourses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.RolePersons", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.RolePersons", "Person_Id", "dbo.People");
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_Id, t.Course_Id })
                .ForeignKey("dbo.Instructors", t => t.Instructor_Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Instructor_Id)
                .Index(t => t.Course_Id);
            
            AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "Id");
            AddForeignKey("dbo.RolePersons", "Role_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.RolePersons", "Person_Id", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePersons", "Person_Id", "dbo.People");
            DropForeignKey("dbo.RolePersons", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.InstructorCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors");
            DropIndex("dbo.InstructorCourses", new[] { "Course_Id" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_Id" });
            DropTable("dbo.InstructorCourses");
            AddForeignKey("dbo.RolePersons", "Person_Id", "dbo.People", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RolePersons", "Role_Id", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
