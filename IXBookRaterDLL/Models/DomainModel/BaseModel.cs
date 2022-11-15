using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IXBookRaterDLL.Models.DomainModel
{
    public class BaseModel
    {
        [Key]
        public int id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModelGuid { get; set; }
    }
}
