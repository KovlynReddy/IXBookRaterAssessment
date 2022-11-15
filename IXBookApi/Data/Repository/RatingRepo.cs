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

        public Rating AddRating()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rating> GetAllRatings()
        {
            return _Db.Ratings.ToList();
        }
    }
}
