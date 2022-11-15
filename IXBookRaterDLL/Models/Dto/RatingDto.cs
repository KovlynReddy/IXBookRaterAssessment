using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.Dto
{
    public  class RatingDto
    {
        public string BookId { get; set; }
        public string BookRating { get; set; }
        public string UserId { get; set; }
    }
}
