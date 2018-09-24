using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VikingNotes.Models;

namespace VikingNotes.ViewModels
{
    public class QuizFormViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public ApplicationUser Author { get; set; } // Who is performing it

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public int Genre { get; set; } // changed the data type to int, because for genre is numeric needed for each option

        [Required]
        public string Description { get; set; }

        public IEnumerable<Genre> Genres { get; set; } // for the 2nd argument of the DropDownListFor in the Create.cshtml there is needed a source for it.

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}