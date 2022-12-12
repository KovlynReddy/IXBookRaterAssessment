using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.Dto
{
    public class CreateBookDto
    {
        public string BookGuid { get; set; } = "";
        public string BookName { get; set; } = "";
        public string BookAuthor { get; set; } = "";
        public double BookAverageRating { get; set; }
    }
}
