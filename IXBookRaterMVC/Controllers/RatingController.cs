using IXBookRaterDLL.Models.ViewModel;
using IXBookRaterMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace IXBookRaterMVC.Controllers
{
    public class RatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RateBook(int id)
        {
            ViewBookViewModel model = new ViewBookViewModel();

            model.IsRating = true;


            return View("Viewbook",model);
        }

        [HttpPost]
        public async Task<IActionResult> RateBook(ViewBookViewModel newRating)
        {
            //await BookRatingService.RateBook(newRating);

            return View();
        }

        public IActionResult RateBookById(int BookId) { 
        
            return View();
        }

        public IActionResult RateBookByGuid(string BookId)
        {

            return View();
        }
    }
}
