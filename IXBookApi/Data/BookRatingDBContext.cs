using IXBookRaterDLL.Models.DomainModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IXBookApi.Data
{
    public class BookRatingDBContext : DbContext
    {
        public BookRatingDBContext(DbContextOptions<BookRatingDBContext> options)
            : base(options)
        { 
        }

        public DbSet<Book> Books { get; set; } 
        public DbSet<Rating> Ratings { get; set; } 
    }
}
