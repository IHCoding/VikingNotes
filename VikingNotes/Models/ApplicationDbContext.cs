using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace VikingNotes.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // follow two DbSet context created to reference them with EF to populate the Migration CreateQuizTable.cs
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Genre> Genres { get; set; } // to query the list of Genres

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}