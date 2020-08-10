using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurkMedya.UI.Web.ORM.Entities.Detail
{
    public class DetailData : Base
    {
        public HeaderAd headerAd { get; set; }
        public NewsDetail newsDetail { get; set; }
        public FooterAd footerAd { get; set; }
        public Multimedia multimedia { get; set; }
        public IList<DetailItemList> itemList { get; set; }
        public RelatedNews relatedNews { get; set; }
        public Video video { get; set; }
        public PhotoGallery photoGallery { get; set; }
    }
}