using System.Linq;
using System.Web.Mvc;
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


        public ActionResult Create()
        {
            var viewModel = new QuizFormViewModel
            {
                Genres = Context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}