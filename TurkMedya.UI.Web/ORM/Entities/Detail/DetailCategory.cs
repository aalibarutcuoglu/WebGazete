using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurkMedya.UI.Web.ORM.Entities.Detail
{
    public class DetailCategory : Base
    {        
        public string title { get; set; }
        public string slug { get; set; }
        public string color { get; set; }
    }
}