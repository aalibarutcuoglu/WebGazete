using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkMedya.UI.Web.ORM.Entities
{
    public class Category : Base
    {        
        public string title { get; set; }
        public string slug { get; set; }
    }
}
