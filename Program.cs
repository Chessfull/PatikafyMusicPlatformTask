using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatikafyMusicPlatformTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Creating List of artist ▼
            List<Artist> artistList = new List<Artist> {
                new Artist { FullName = "Ajda Pekkan", MusicType = "Pop", AlbumDate = new DateTime(1968,1,1), AlbumSales = 20000000 },
                new Artist { FullName = "Sezen Aksu", MusicType = "Türk Halk Müziği / Pop", AlbumDate =new DateTime(1971,1,1), AlbumSales = 10000000 },
                new Artist { FullName = "Funda Arar", MusicType = "Pop", AlbumDate = new DateTime(1999,1,1), AlbumSales = 3000000 },
                new Artist { FullName = "Sertab Erener", MusicType = "Pop", AlbumDate = new DateTime(1994,1,1), AlbumSales = 5000000 },
                new Artist { FullName = "Sıla", MusicType = "Pop", AlbumDate = new DateTime(2009,1,1), AlbumSales = 3000000 },
                new Artist { FullName = "Serdar Ortaç", MusicType = "Pop", AlbumDate = new DateTime(1994,1,1), AlbumSales = 10000000 },
                new Artist { FullName = "Tarkan", MusicType = "Pop", AlbumDate = new DateTime(1992,1,1), AlbumSales = 40000000 },
                new Artist { FullName = "Hande Yener", MusicType = "Pop", AlbumDate = new DateTime(1999,1,1), AlbumSales = 7000000 },
                new Artist { FullName = "Hadise", MusicType = "Pop", AlbumDate = new DateTime(2005,1,1), AlbumSales = 5000000 },
                new Artist { FullName = "Gülben Ergen", MusicType = "Pop / Türk Halk Müziği", AlbumDate = new DateTime(1997,1,1), AlbumSales = 10000000 },
                 new Artist { FullName = "Neşet Ertaş", MusicType = "Türk Halk Müziği / Türk Sanat Müziği", AlbumDate = new DateTime(1960,1,1), AlbumSales = 2000000 }
            };

            // ▼ Artists who names start with 'S' ▼
            List<Artist> startsWithA = artistList.Where(I => I.FullName.StartsWith("A")).ToList();

            // ▼ Over 10 million album sales ▼
            List<Artist> overTenMillion = artistList.Where(I => I.AlbumSales > 10000000).ToList();

            // ▼ Before 2000 ▼
            List<Artist> before2000 = artistList.Where(I => I.AlbumDate < new DateTime(2000,1,1)).ToList();

            // ▼ Best Selling Artist ▼
            Artist bestSelling = artistList.OrderByDescending(I => I.AlbumSales).First();

            // ▼ Oldest and newest album ▼
            Artist oldestAlbum=artistList.OrderBy(I=>I.AlbumDate).First();
            Artist newestAlbum = artistList.OrderByDescending(I => I.AlbumDate).First();
        }
    }
}
