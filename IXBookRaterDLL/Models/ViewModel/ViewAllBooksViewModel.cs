using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.ViewModel
{
    public class ViewAllBooksViewModel
    {
        public List<ViewBookViewModel> Books { get; set; } = new List<ViewBookViewModel>();
    }
}
