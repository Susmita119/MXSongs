using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options ) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<MXSong> MXSongs {get; set; }


        protected override void OnModelCreating (ModelBuilder builder )
        {

              builder.Entity<Song>()
            .HasData(
                new Song(){Id=5 , Name = "Kaun tujhe" ,Artist = "Palak Muchhal" , Movie="MS Dhoni"},
                new Song(){Id=6 , Name = "Mile ho tum" ,Artist = "Neha Kakkar" , Movie="Fever"},
                new Song(){Id=7 , Name = "Mahi ve" ,Artist = "Neha Kakkar" , Movie="Wajah tum"},
                new Song(){Id=8 , Name = "Coca cola" ,Artist = "Young Desi" , Movie="Luka Chuppi"}

            );
            
            builder.Entity<Value>()
            .HasData(
                new Value(){ Id = 1 , Name = "Value 101"},
                new Value(){ Id = 2 , Name = "Value 102"},
                new Value(){ Id = 3 , Name = "Value 103"}

            );

          

        }
    }

         
}
