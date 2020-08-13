using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace BlzTest.Data.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Fish> Fish { get; set; }
        public DbSet<Lake> Lake { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options){
         //   => options.UseSqlite("Data Source=DNRSurvey.db");
            options.UseSqlServer( @"Data Source=.;Initial Catalog=DNRSurvey;Integrated Security=true");
        }
    }

    public class Lake
    {
        public int Id { get; set; }
        
        public string LakeName { get; set; }

        public string DnrNumber { get; set; }

        public string Tier { get; set; }

        public string County { get; set; }
        
        public string EcoRegion { get; set; }

        public string IsSentinel { get; set; }

    }

    public class Fish
    {
        public int Id { get; set; }
    
        public int LakeId { get; set; }

        public string FishName { get; set; }

    }
}