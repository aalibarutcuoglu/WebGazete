using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkMedya.DataAccess.ORM.Entities;

namespace TurkMedya.DataAccess.ORM.Context
{
    public class TurkMedtaDbContext : DbContext
    {
        public TurkMedtaDbContext()
        {
            Database.Connection.ConnectionString = "Server=BAHAR\\BAHARSQL;Database=TurkMedya;Trusted_Connection=True;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }

    }
}
