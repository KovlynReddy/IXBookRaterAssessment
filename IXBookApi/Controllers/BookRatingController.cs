using IXBookRaterDLL.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace IXBookApi.Controllers;

[AllowAnonymous]
[Route("api/[controller]")]
//[Route("~/api/[controller]")]
[ApiController]
public class BookRatingController : ControllerBase
{
    public IRatingRepo _ratingDb { get; set; }
    public IBookRepo _bookDb { get; set; }

    public BookRatingController(IRatingRepo ratingDb, IBookRepo bookDb)
    {
        _bookDb= bookDb;
        _ratingDb = ratingDb;
    }
    
    //[HttpPost(Name = "RateBook")]
    //[Route("~/RateBook")]
    //public ActionResult<RateBookDto> RateBook([FromBody]RateBookDto newRating)
    //{
    //    Rating rating = new Rating { 
        
    //    };
    //    //_ratingDb.AddRating(rating);

    //    return Ok();
    //}

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = _bookDb.GetAllBooks().ToList();

        if (result.Count == 0 || result == new List<Book>())
        {
            List<Book> books = new List<Book>();

            for (int i = 0; i < 5; i++)
            {
                var newBook = new Book
                {
                    BookAuthor = $"Author{i}",
                    BookAverageRating = (i % 5),
                    BookGuid = i.ToString(),
                    BookName = $"Boook{i}"
                };

                books.Add(newBook);
            }

            result.AddRange(books);
        }

       
        return Ok(result);
    }


    //[Route("~/CreateBook")]
    //[Route("~/[action]")]
    //[Route("/[controller]/[action]")]
    [HttpPost]
    public async Task<ActionResult> Post([FromBody]CreateBookDto newBook)
    {
        Book book = new Book { 
        BookName=newBook.BookName,
        BookAuthor=newBook.BookAuthor,
        BookGuid =  Guid.NewGuid().ToString(),
        ModelGuid = Guid.NewGuid().ToString(),
        LastUpdated = DateTime.Now,
        BookAverageRating = 0 ,
        CreatedDateTime = DateTime.Now

        };
        var result = _bookDb.CreateBook(book);
        return Ok(result);
    }

}
