using AlicanApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;

namespace AlicanApi.DataAccess.Context
{
    public class DataContext:DbContext
    {
        public DataContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ROTCU0Q;Initial Catalog=MapServicesDb;Integrated Security = True;TrustServerCertificate=True");
        }

        // best practise gereği tablo adları çoğul olmalı
      public DbSet<Store> Stores { get; set; }
      public DbSet<Carrier> Carriers { get; set; }
    }
}
