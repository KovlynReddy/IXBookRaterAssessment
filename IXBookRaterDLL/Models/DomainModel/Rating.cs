using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.DomainModel
{
    public class Rating : BaseModel
    {
        public string BookId { get; set; }
        public string BookRating { get; set; }
        public string UserId { get; set; }
    }
}
