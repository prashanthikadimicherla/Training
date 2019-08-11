namespace Training.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrainingDetails", "TrainingName", c => c.String());
            AlterColumn("dbo.TrainingDetails", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TrainingDetails", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainingDetails", "EndDate", c => c.Int(nullable: false));
            AlterColumn("dbo.TrainingDetails", "StartDate", c => c.Int(nullable: false));
            AlterColumn("dbo.TrainingDetails", "TrainingName", c => c.Int(nullable: false));
        }
    }
}
