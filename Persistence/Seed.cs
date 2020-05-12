using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context){

            if(!context.MXSongs.Any())
            {
                var songs = new List<MXSong>
                {

                    new MXSong
                    {
                        Name = "Tum Hi Ho",
                        Artist = "Arijit Singh",
                        Movie = "Aashiqui 2",
                        Date = DateTime.Now.AddMonths(-2),
                    },
                    new MXSong
                    {
                        Name = "Janam Janam",
                        Artist = "Antara Mitra",
                        Movie = "Dilwale",
                        Date = DateTime.Now.AddMonths(-1),
                    },
                    new MXSong
                    {
                        Name = "Vaaste",
                        Artist = "Dhvani Bhanushali",
                        Movie = "Vaaste",
                        Date = DateTime.Now.AddMonths(1),
                    },
                    new MXSong
                    {
                        Name = "Leja Re",
                        Artist = "Dhvani Bhanushali",
                        Movie = "Leja Re",
                        Date = DateTime.Now.AddMonths(2),
                    },
                    new MXSong
                    {
                        Name = "Meri Aashiqui",
                        Artist = " Arijit Singh",
                        Movie = "Aashiqui 2",
                        Date = DateTime.Now.AddMonths(3),
                    },
                    new MXSong
                    {
                        Name = "Soch Na Sake",
                        Artist = "Arijit Singh",
                        Movie = "Airlift",
                        Date = DateTime.Now.AddMonths(4),
                    },
                    new MXSong
                    {
                        Name = "Bala bala",
                        Artist = "Sohail Sen",
                        Movie = "Housefull 4",
                        Date = DateTime.Now.AddMonths(5),
                    },
                    new MXSong
                    {
                        Name = "Tera Ban Jaunga",
                        Artist = "Tulsi Kumar",
                        Movie = "Kabir Singh",
                        Date = DateTime.Now.AddMonths(6),
                    },
                    new MXSong
                    {
                        Name = "Gerua",
                        Artist = "Arijit Singh",
                        Movie = "Dilwale",
                        Date = DateTime.Now.AddMonths(7),
                    },
                    new MXSong
                    {
                        Name = "Pachtaoge",
                        Artist = "Nora Fatehi",
                        Movie = "Pachtaoge",
                        Date = DateTime.Now.AddMonths(8),
                    }

                };

                context.MXSongs.AddRange(songs);
                context.SaveChanges();
            }

        }
    }
}