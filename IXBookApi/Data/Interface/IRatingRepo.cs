using IXBookRaterDLL.Models.DomainModel;
using IXBookRaterDLL.Services;

namespace IXBookApi.Data.Interface
{
    public interface IRatingRepo
    {
        public Rating AddRating();
        public IEnumerable<Rating> GetAllRatings();

    }
}
