using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkMedya.DataAccess.ORM.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public int errorCode { get; set; }
        public object errorMessage { get; set; }
        public IList<Data> data { get; set; }
    }
}
