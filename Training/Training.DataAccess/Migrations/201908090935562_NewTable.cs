namespace Training.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainingDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainingName = c.Int(nullable: false),
                        StartDate = c.Int(nullable: false),
                        EndDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrainingDetails");
        }
    }
}
