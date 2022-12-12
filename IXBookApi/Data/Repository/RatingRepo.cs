using IXBookApi.Data.Interface;
using IXBookRaterDLL.Models.DomainModel;

namespace IXBookApi.Data.Repository
{
    public class RatingRepo : IRatingRepo
    {
        public BookRatingDBContext _Db { get; set; }
        public RatingRepo(BookRatingDBContext db)
        {
            _Db = db;
        }

        public Rating AddRating(Rating newRating)
        {
            _Db.Ratings.Add(newRating);
            _Db.SaveChanges();

            var currentBook = _Db.Books.FirstOrDefault(m=>m.BookGuid== newRating.BookId || m.ModelGuid==newRating.BookId);
            var allRatings = _Db.Ratings.Where(m => m.BookId == newRating.BookId);

            var averageRating = allRatings.Select(m=>Convert.ToInt32(m.BookRating)).ToList().Average();
            currentBook.BookAverageRating = averageRating;
            currentBook.LastUpdated = DateTime.Now;

            _Db.Update(currentBook);
            _Db.SaveChanges();

            return newRating;
        }

        public IEnumerable<Rating> GetAllRatings()
        {
            return _Db.Ratings.ToList();
        }
    }
}
