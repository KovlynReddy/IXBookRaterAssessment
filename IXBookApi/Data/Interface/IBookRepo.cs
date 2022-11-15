using IXBookRaterDLL.Models.DomainModel;

namespace IXBookApi.Data.Interface
{
    public interface IBookRepo
    {
        public IEnumerable<Book> GetAllBooks();
        public Book UpdateBook();
        public Book CreateBook(Book book);
    }
}
