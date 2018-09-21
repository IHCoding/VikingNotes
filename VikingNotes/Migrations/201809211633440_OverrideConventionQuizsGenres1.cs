namespace VikingNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionQuizsGenres1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Quizs", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Quizs", "Description", c => c.String());
        }
    }
}
