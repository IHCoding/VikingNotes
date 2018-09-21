using System;
using System.ComponentModel.DataAnnotations;

namespace VikingNotes.Models
{
    public class Quiz
    {
        public int ID { get; set; } // unique id

        // assoiciating the user with the AplicationUser class that represents the VikingNotes
        [Required]
        public ApplicationUser Student { get; set; } // Who is performing it

        [Required, StringLength(Int32.MaxValue)]
        public string Description { get; set; } // Quiz Description text

        public DateTime DateTime { get; set; } // when is it happening

        [Required]
        public Genre Genre { get; set; } // what genre is it
    }
}