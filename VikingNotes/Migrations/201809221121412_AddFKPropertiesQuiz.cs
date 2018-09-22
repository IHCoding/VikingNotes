namespace VikingNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKPropertiesQuiz : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Quizs", name: "Author_Id", newName: "AuthorId");
            RenameColumn(table: "dbo.Quizs", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.Quizs", name: "IX_Author_Id", newName: "IX_AuthorId");
            RenameIndex(table: "dbo.Quizs", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Quizs", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameIndex(table: "dbo.Quizs", name: "IX_AuthorId", newName: "IX_Author_Id");
            RenameColumn(table: "dbo.Quizs", name: "GenreId", newName: "Genre_Id");
            RenameColumn(table: "dbo.Quizs", name: "AuthorId", newName: "Author_Id");
        }
    }
}
