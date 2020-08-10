using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurkMedya.UI.Web.ORM.Entities.Detail
{
    public class Example : Base
    {
        public int errorCode { get; set; }
        public object errorMessage { get; set; }
        public DetailData data { get; set; }
    }
}