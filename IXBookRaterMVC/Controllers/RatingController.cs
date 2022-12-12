using IXBookRaterDLL.Models.Dto;
using IXBookRaterDLL.Models.ViewModel;
using IXBookRaterMVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IXBookRaterMVC.Controllers
{
    //[Authorize]
    public class RatingController : Controller
    {
        public async Task< IActionResult> ViewAll()
        {
           // var allratings = await BookRatingService.GetAllRatings();

            return View();
        }

        public async Task<IActionResult> RateBook(string id)
        {

            // fetch data with id
            var allbooks = await BookRatingService.GetAllBookings();
            var currentBook = allbooks.FirstOrDefault(m => m.BookGuid == id||m.ModelGuid==id);

            ViewBookViewModel model = new ViewBookViewModel() { 
            BookAuthor = currentBook.BookAuthor,
            BookAverageRating = currentBook.BookAverageRating.ToString(),
            BookId = currentBook.BookGuid,
            BookName = currentBook.BookName,
            IsRating  =true
            };
            // set isRating of model



            return View("RateBook",model);
        }

        [HttpPost]
        public async Task<IActionResult> RateBook(ViewBookViewModel newRating)
        {
            // call api
           
            RateBookDto newrating = new RateBookDto() {
                BookGuid = newRating.BookId,
                BookRating = newRating.BookAverageRating,
            UserId = Guid.NewGuid().ToString()
            };

            await BookRatingService.RateBook(newrating);

            return RedirectToAction("ViewAll",controllerName:"Book");
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
