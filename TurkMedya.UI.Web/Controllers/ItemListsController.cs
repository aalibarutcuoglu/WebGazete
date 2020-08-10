using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TurkMedya.UI.Web.ORM.Context;
using TurkMedya.UI.Web.ORM.Entities;

namespace TurkMedya.UI.Web.Controllers
{
    public class ItemListsController : Controller
    {
        private TurkMedyaDbContext db = new TurkMedyaDbContext();

        
        public ActionResult Index()
        {
            string adres = "http://turkmedya.com.tr/anasayfa.json";
            WebRequest istek = HttpWebRequest.Create(adres); // istek yolladık
            WebResponse cevap = istek.GetResponse(); // cevabı aldık
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); // cevabı okuduk
            string bilgilerial = donenBilgiler.ReadToEnd(); // okuduğumuz cevabı stringe atadık
            List<ItemList> itemLists = JsonConvert.DeserializeObject<List<ItemList>>(bilgilerial);

           

            return View(db.ItemLists.ToList());
        }

      

       
    }
}
