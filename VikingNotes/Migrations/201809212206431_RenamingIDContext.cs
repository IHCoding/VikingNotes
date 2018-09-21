namespace VikingNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamingIDContext : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Quizs", new[] { "Genre_ID" });
            CreateIndex("dbo.Quizs", "Genre_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Quizs", new[] { "Genre_Id" });
            CreateIndex("dbo.Quizs", "Genre_ID");
        }
    }
}
