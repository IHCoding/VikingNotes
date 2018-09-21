using System.ComponentModel.DataAnnotations;

namespace VikingNotes.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}