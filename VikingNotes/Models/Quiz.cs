using System;
using System.ComponentModel.DataAnnotations;

namespace VikingNotes.Models
{
    public class Quiz
    {
        public int Id { get; set; } // unique id

        // assoiciating the user with the AplicationUser class that represents the VikingNotes
        public ApplicationUser Author { get; set; } // Who is performing it

        [Required] // moved from the Author, making sure the FK is set to this, not Author.
        public string AuthorId { get; set; } // string as in the ApplicationUser, Identity, the ID property, which is key is defined as string.

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(Int32.MaxValue)]
        public string Description { get; set; } // Quiz Description text

        public DateTime DateTime { get; set; } // when is it happening


        public Genre Genre { get; set; } // what genre is it

        [Required] // moved from Genre to GenreId, setting FK to this.
        public int GenreId { get; set; }
    }
}

// Author and Genre are navigation properties, for it allowing us to navigate into different entities in the domain model.
// giving them a FK property each (AuthorID, GenreID), will address the issue of querying for Author and Genre in the QuizsController.cs for the 
// target action. This way setting their value without querying a complet application user object.