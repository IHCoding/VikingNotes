using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using VikingNotes.Models;
using VikingNotes.ViewModels;

namespace VikingNotes.Controllers
{
    public class QuizsController : Controller
    {
        // Getting list of genres from the database
        private ApplicationDbContext Context { get; set; }

        public QuizsController()
        {
            Context = new ApplicationDbContext();
        }


        [Authorize] // added to prompt user to log in (limiting only to logged in users to create quiz)
        public ActionResult Create()
        {
            var viewModel = new QuizFormViewModel
            {
                Genres = Context.Genres.ToList()
            };

            return View(viewModel);
        }


        // Implementing the Create action for the Target form in the Create.cshtml
        [Authorize, HttpPost] // httpPost to prompt this action being called only by a httpPost method

        public ActionResult Create(QuizFormViewModel viewModel) // takes parameter of QuizFormViewModel -- the model behind the view. When posting the form will result this action
        {
            // Step 1: // getting an ApplicationUser object to set the user logged in from the database
            // returns an application user object that can be associated with this Quiz.
            var userId = User.Identity.GetUserId(); // passing this variable to the argument will be numeric value. It is easy for the EF to translate it to sql.
            var author = Context.Users.Single(u => u.Id == userId);

            // Step 2: // similarly need to read the genre from the database like the author/users.
            // get the genres, whose id is viewModel. It's an int type.
            var genre = Context.Genres.Single(g => g.Id == viewModel.Genre);

            // quiz object
            var quiz = new Quiz // creating new Quiz object and converting it to the viewModel object
            {
                // need to set the author, need an applicationUser object
                Author = author,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Title = viewModel.Title,
                Description = viewModel.Description
            };

            // adding the object to the contex to be tracked by EF
            // Ef will generate a sql statment and execute it against the database.
            Context.Quizzes.Add(quiz);
            Context.SaveChanges();

            return RedirectToAction("Index", "Home"); // redirecting the user to the homepage --> later to the list of all the upcoming quizzes
        }
    }
}