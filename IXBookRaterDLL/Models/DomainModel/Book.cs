using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.DomainModel
{
    public class Book : BaseModel
    {
        [Key]
        public int id { get; set; }
        public string BookGuid { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public double BookAverageRating { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
