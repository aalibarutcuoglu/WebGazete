using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkMedya.UI.Web.ORM.Entities
{
    public class Application : Base
    {        
        public int errorCode { get; set; }
        public object errorMessage { get; set; }
        public IList<Data> data { get; set; }
    }
}
