using IXBookApi.Data.Interface;
using IXBookRaterDLL.Models.DomainModel;
using IXBookRaterDLL.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IXBookApi.Controllers
{
    [Route("~/api/BookRating")]
    public class BookRatingController : Controller
    {
        public IRatingRepo _ratingDb { get; set; }
        public IBookRepo _bookDb { get; set; }

        public BookRatingController(IRatingRepo ratingDb, IBookRepo bookDb)
        {
            _bookDb= bookDb;
            _ratingDb = ratingDb;
        }
        
        [HttpPost]
        [Route("~/RateBook")]
        public ActionResult RateBook(RateBookDto newRating)
        {
            Rating rating = new Rating { 
            
            };
            //_ratingDb.AddRating(rating);

            return Ok();
        }

        [HttpGet]
        [Route("~/GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = _bookDb.GetAllBooks();
            return Ok(result);
        }

        [HttpPost]
        [Route("~/CreateBook")]
        public ActionResult CreateBook(CreateBookDto newBook)
        {
            Book book = new Book { 
            
            };
            var result = _bookDb.CreateBook(book);
            return Ok(result);
        }

        // GET: BookRatingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookRatingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookRatingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookRatingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookRatingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookRatingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
