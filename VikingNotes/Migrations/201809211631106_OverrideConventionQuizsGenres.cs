namespace VikingNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionQuizsGenres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Quizs", "Genre_ID", "dbo.Genres");
            DropForeignKey("dbo.Quizs", "Student_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Quizs", new[] { "Genre_ID" });
            DropIndex("dbo.Quizs", new[] { "Student_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Quizs", "Genre_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Quizs", "Student_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Quizs", "Genre_ID");
            CreateIndex("dbo.Quizs", "Student_Id");
            AddForeignKey("dbo.Quizs", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Quizs", "Student_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quizs", "Student_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Quizs", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Quizs", new[] { "Student_Id" });
            DropIndex("dbo.Quizs", new[] { "Genre_ID" });
            AlterColumn("dbo.Quizs", "Student_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Quizs", "Genre_ID", c => c.Int());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Quizs", "Student_Id");
            CreateIndex("dbo.Quizs", "Genre_ID");
            AddForeignKey("dbo.Quizs", "Student_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Quizs", "Genre_ID", "dbo.Genres", "ID");
        }
    }
}
