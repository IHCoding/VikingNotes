namespace VikingNotes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedQuizTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Quizs", name: "Student_Id", newName: "Author_Id");
            RenameIndex(table: "dbo.Quizs", name: "IX_Student_Id", newName: "IX_Author_Id");
            AddColumn("dbo.Quizs", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quizs", "Title");
            RenameIndex(table: "dbo.Quizs", name: "IX_Author_Id", newName: "IX_Student_Id");
            RenameColumn(table: "dbo.Quizs", name: "Author_Id", newName: "Student_Id");
        }
    }
}
