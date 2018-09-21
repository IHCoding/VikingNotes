namespace VikingNotes.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (ID, Name) VALUES (1,'Medicinsk filosofi og videnskabsteori')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (2,'Medicinsk genetik')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (3,'Mikroskopisk anatomi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (4,'Embryologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (5,'Makroskopisk anatomi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (6,'Neuroanatomi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (7,'Medicinsk biokemi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (8,'Fysiologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (9,'Sundhedpsykologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (10,'Epidemiologi og biostatistik')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (11,'Mikrobiologi og Immunologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (12,'Miljø- og arbejdsjdsmedicin')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (13,'Farmakologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (14,'Patologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (15,'Inflammation')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (16,'Socialmedicin')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (17,'Abdomen')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (18,'HLK')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (19,'Neuro')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (20,'Oftalmologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (21,'Psykiatri')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (22,'ØNH')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (23,'Klinisk Genetik')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (24,'Retsmedicin')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (25,'Akutmedicin')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (26,'Almen medicin')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (27,'Dermato-venerologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (28,'Endokrinologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (29,'Farmakologi')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (30,'Geriatri')");
            Sql("INSERT FROM Genres (ID, Name) VALUES (31,'Ortopædkirurgi')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE ID IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31)");
        }
    }
}