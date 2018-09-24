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


        
        [Authorize, HttpPost] // httpPost to prompt this action being called only by a httpPost method
                // Implementing the Create action for the Target form in the Create.cshtml
        public ActionResult Create(QuizFormViewModel viewModel) // takes parameter of QuizFormViewModel -- the model behind the view. When posting the form will result this action
        {
            // step : validation
            if (!ModelState.IsValid) // is property of the controller.
            {
                // step exception fix for Genre not populated - Value cannot be null
                viewModel.Genres = Context.Genres.ToList();

                return View("Create", viewModel); // return create viewe, using the viewModel past to this method
                    // when returning the view, all the existing values displayed in the input fields along with validation messages.
            }


                 // creating new Quiz object and converting it to the viewModel object
            var quiz = new Quiz
            {
                 // need to set the authorId, need an applicationUser object
                AuthorId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
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