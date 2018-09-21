using System.Linq;
using System.Web.Mvc;
using VikingNotes.Models;
using VikingNotes.ViewModels;

namespace VikingNotes.Controllers
{
    public class QuizsController : Controller
    {
        // Getting list of genres from the database
        private ApplicationDbContext _Context { get; set; }

        public QuizsController()
        {
            _Context = new ApplicationDbContext();
        }



        // GET: Quizs
        public ActionResult Create()
        {
            var viewModel = new QuizFormViewModel
            {
                Genres = _Context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}