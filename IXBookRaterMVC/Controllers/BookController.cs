using IXBookRaterDLL.Models.ViewModel;
using IXBookRaterMVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IXBookRaterMVC.Controllers
{
    //[Authorize]
    public class BookController : Controller
    {
        public async Task<IActionResult> RateBook(string id)
        {
           
            return View();
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookViewModel newBook)
        {
            await BookRatingService.CreateBook(newBook);


            return View();
        }

        public async Task<IActionResult> ViewAll() {

            await BookRatingService.GetAllBookings();

            ViewAllBooksViewModel model = new ViewAllBooksViewModel();

            List<ViewBookViewModel> books = new List<ViewBookViewModel>();

            for (int i = 0; i < 5; i++)
            {
                var newBook = new ViewBookViewModel
                {
                    BookAuthor = $"Author{i}", 
                    BookAverageRating =  (i%5).ToString(),
                    BookId = i.ToString(),
                    BookName = $"Boook{i}" 
                };

                books.Add(newBook);
            }

            model.Books = books;

            return View(model);
        }
    }
}
