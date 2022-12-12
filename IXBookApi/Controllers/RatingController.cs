using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IXBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {

        public IRatingRepo _ratingDb { get; set; }
        public IBookRepo _bookDb { get; set; }

        public RatingController(IRatingRepo ratingDb, IBookRepo bookDb)
        {
            _bookDb = bookDb;
            _ratingDb = ratingDb;
        }


        //[HttpGet(Name = "GetAllBooks")]
        //[Route("/[controller]/[action]")]
        //[Route("~/[action]")]
        //public async Task<IActionResult> GetAllBooks()
        //{
        //    var result = _bookDb.GetAllBooks();
        //    return Ok(result);
        //}
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] RateBookDto value)
        {
            Rating newRating = new Rating() { 
            BookId = value.BookGuid,
            BookRating = value.BookRating,
            ModelGuid = Guid.NewGuid().ToString(),
            CreatedDateTime = DateTime.Now,
            UserId = value.UserId
            };
            _ratingDb.AddRating(newRating);


            return Ok(newRating);
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
