using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkMedya.DataAccess.ORM.Entities
{
    public class Category
    {
        public string categoryId { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
    }
}
