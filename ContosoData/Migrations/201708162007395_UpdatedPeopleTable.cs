namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPeopleTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Unit", c => c.Int());
            AlterColumn("dbo.People", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.People", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.People", "IsLocked", c => c.Boolean());
            AlterColumn("dbo.People", "LastLockedDateTime", c => c.DateTime());
            AlterColumn("dbo.People", "FailedAttempts", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "FailedAttempts", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "LastLockedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "IsLocked", c => c.Boolean(nullable: false));
            AlterColumn("dbo.People", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "Unit", c => c.Int(nullable: false));
        }
    }
}
