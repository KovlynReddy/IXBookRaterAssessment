using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.ViewModel
{
    public class RateBookingViewModel
    {
        public ViewAllBooksViewModel Book { get; set; }
        public string UserGuid { get; set; }
        public int Rating { get; set; }
    }
}
