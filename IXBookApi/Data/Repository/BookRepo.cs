using IXBookApi.Data.Interface;
using IXBookRaterDLL.Models.DomainModel;

namespace IXBookApi.Data.Repository
{
    public class BookRepo : IBookRepo
    {
        public BookRatingDBContext _Db { get; set; }
        public BookRepo(BookRatingDBContext db)
        {
            _Db = db;
        }
        public IEnumerable<Book> GetAllBooks()
        {
           return _Db.Books.ToList();
        }

        public Book CreateBook(Book newBook) {

            _Db.Add(newBook);
            _Db.SaveChanges();

            return newBook;
        }

        public Book UpdateBook()
        {
            _Db.SaveChanges();
            throw new NotImplementedException();
        }
    }
}
