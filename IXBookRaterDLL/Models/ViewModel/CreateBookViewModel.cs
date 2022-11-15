using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.ViewModel
{
    public  class CreateBookViewModel
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public double BookAverageRating { get; set; }
    }
}
