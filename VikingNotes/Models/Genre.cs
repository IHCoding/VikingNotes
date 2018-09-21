﻿using System.ComponentModel.DataAnnotations;

namespace VikingNotes.Models
{
    public class Genre
    {
        //[ScaffoldColumn(false)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}