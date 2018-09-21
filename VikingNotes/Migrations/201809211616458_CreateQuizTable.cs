namespace VikingNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateQuizTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Genre_ID = c.Int(),
                        Student_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.Genre_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.Student_Id)
                .Index(t => t.Genre_ID)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quizs", "Student_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Quizs", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Quizs", new[] { "Student_Id" });
            DropIndex("dbo.Quizs", new[] { "Genre_ID" });
            DropTable("dbo.Quizs");
            DropTable("dbo.Genres");
        }
    }
}
