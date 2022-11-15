using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.ViewModel
{
    public class ViewBookViewModel
    {
        public string BookId { get; set; }
        public string BookAverageRating { get; set; }
        public string BookAuthor { get; set; }
        public string BookName { get; set; }
        public bool IsRating { get; set; }
    }
}
