using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurkMedya.UI.Web.ORM.Entities.Detail
{
    public class FooterAd : Base
    {
        public string itemType { get; set; }
        public string adUnit { get; set; }
        public int itemWidth { get; set; }
        public int itemHeight { get; set; }
    }
}