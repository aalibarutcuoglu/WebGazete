using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkMedya.UI.Web.ORM.Entities;
using TurkMedya.UI.Web.ORM.Entities.Detail;

namespace TurkMedya.UI.Web.ORM.Context
{
    public class TurkMedyaDbContext : DbContext
    {
        public TurkMedyaDbContext()
        {
            Database.Connection.ConnectionString = "Server=BAHAR\\BAHARSQL;Database=TurkMedyaDb;Trusted_Connection=True;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<DetailCategory> DetailCategories { get; set; }
        public DbSet<DetailData> DetailDatas { get; set; }
        public DbSet<Example> Examples { get; set; }
        public DbSet<FooterAd> FootersAd { get; set; }
        public DbSet<HeaderAd> HeadersAd { get; set; }
        public DbSet<DetailItemList> DetailItemLists { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }
        public DbSet<NewsDetail> NewsDetails{ get; set; }
        public DbSet<PhotoGallery> PhotoGalleries{ get; set; }
        public DbSet<RelatedNews> RelatedNews{ get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }

    }
}
