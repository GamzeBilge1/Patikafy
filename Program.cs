using System;
using System.Collections.Generic;
using System.Linq;

namespace Patikafy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Şarkıcı listesi
            List<Singer> singers = new List<Singer>
            {
                new Singer { FullName = "Ajda Pekkan", MusicGenre = "Pop", DebutYear = 1968, AlbumSalesInMillions = 20 },
                new Singer { FullName = "Sezen Aksu", MusicGenre = "Türk Halk Müziği / Pop", DebutYear = 1971, AlbumSalesInMillions = 10 },
                new Singer { FullName = "Funda Arar", MusicGenre = "Pop", DebutYear = 1999, AlbumSalesInMillions = 3 },
                new Singer { FullName = "Sertab Erener", MusicGenre = "Pop", DebutYear = 1994, AlbumSalesInMillions = 5 },
                new Singer { FullName = "Sıla", MusicGenre = "Pop", DebutYear = 2009, AlbumSalesInMillions = 3 },
                new Singer { FullName = "Serdar Ortaç", MusicGenre = "Pop", DebutYear = 1994, AlbumSalesInMillions = 10 },
                new Singer { FullName = "Tarkan", MusicGenre = "Pop", DebutYear = 1992, AlbumSalesInMillions = 40 },
                new Singer { FullName = "Hande Yener", MusicGenre = "Pop", DebutYear = 1999, AlbumSalesInMillions = 7 },
                new Singer { FullName = "Hadise", MusicGenre = "Pop", DebutYear = 2005, AlbumSalesInMillions = 5 },
                new Singer { FullName = "Gülben Ergen", MusicGenre = "Pop / Türk Halk Müziği", DebutYear = 1997, AlbumSalesInMillions = 10 },
                new Singer { FullName = "Neşet Ertaş", MusicGenre = "Türk Halk Müziği / Türk Sanat Müziği", DebutYear = 1960, AlbumSalesInMillions = 2 }
            };

            // 'S' harfi ile başlayan şarkıcılar
            var startsWithS = singers.Where(s => s.FullName.StartsWith("S"));
            Console.WriteLine("Adı S harfi ile başlayan şarkıcılar:");
            foreach (var s in startsWithS)
            {
                Console.WriteLine(s.FullName);
            }

            Console.WriteLine("--------------------------------------------");

            // Albüm satışları 10 milyonun üzerinde olan şarkıcılar
            var highSales = singers.Where(s => s.AlbumSalesInMillions > 10);
            Console.WriteLine("Albüm Satışları 10 milyonun üzerinde olan şarkıcılar:");
            foreach (var s in highSales)
            {
                Console.WriteLine(s.FullName);
            }

            Console.WriteLine("--------------------------------------------");

            // 2000 yılından önce çıkış yapan ve Pop müzik türü içeren şarkıcılar
            var pre2000Pop = singers.Where(s => s.DebutYear < 2000 && s.MusicGenre.Contains("Pop"));
            Console.WriteLine("2000 yılından önce çıkış yapan ve Pop müzik türü içeren şarkıcılar:");
            foreach (var s in pre2000Pop)
            {
                Console.WriteLine(s.FullName);
            }

            Console.WriteLine("--------------------------------------------");

            // En çok albüm satan şarkıcı
            var topSeller = singers.OrderByDescending(s => s.AlbumSalesInMillions).First();
            Console.WriteLine($"En çok albüm satan şarkıcı: {topSeller.FullName} - {topSeller.AlbumSalesInMillions} milyon");

            Console.WriteLine("--------------------------------------------");

            // En yeni ve en eski çıkış yapan şarkıcı
            var newest = singers.OrderByDescending(s => s.DebutYear).First();
            var oldest = singers.OrderBy(s => s.DebutYear).First();
            Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newest.FullName}");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldest.FullName}");
        }
    }
}