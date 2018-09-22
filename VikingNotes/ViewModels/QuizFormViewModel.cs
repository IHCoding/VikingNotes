using System;
using System.Collections.Generic;
using VikingNotes.Models;

namespace VikingNotes.ViewModels
{
    public class QuizFormViewModel
    {
        public ApplicationUser Author { get; set; } // Who is performing it

        public string Title { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public int Genre { get; set; } // changed the data type to int, because for genre is numeric needed for each option

        public string Description { get; set; }

        public IEnumerable<Genre> Genres { get; set; } // for the 2nd argument of the DropDownListFor in the Create.cshtml there is needed a source for it.

        public DateTime DateTime
        {
            get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
    }
}