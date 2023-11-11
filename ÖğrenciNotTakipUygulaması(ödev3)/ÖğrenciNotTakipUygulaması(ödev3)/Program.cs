using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciNotTakipUygulaması_ödev3_
{
    public class Ogrenci
   {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }
        public int[] Notlar { get; set; }

        public static double Ortalama(int[] notlar)
        {
            if (notlar.Length == 0)
                return 0;

            double toplam = 0;
            foreach (var not in notlar)
            {
                toplam += not;
            }

            return toplam / notlar.Length; //return notlar.Average(); kullanabilirmişim tamamının yerine
        }
    }
    public class Personel : Ogrenci
    {
        public string Gorev { get; set; }
    }
    internal class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Bilgilerini Girin:");
            Ogrenci ogrenci = OgrenciBilgileriAl();
            /*Console.Write("Ad: ");
            string ogrenciAd = Console.ReadLine();

            Console.Write("Soyad: ");
            string ogrenciSoyad = Console.ReadLine();

            Console.Write("Numara: ");
            int ogrenciNumara = Convert.ToInt32(Console.ReadLine());

            Console.Write("Notlar (tire(-) ile ayırarak girin): ");
            string[] notlarStr = Console.ReadLine().Split(',');
            int[] ogrenciNotlar = Array.ConvertAll(notlarStr, int.Parse);

            Ogrenci ogrenci = new Ogrenci
            {
                Ad = ogrenciAd,
                Soyad = ogrenciSoyad,
                Numara = ogrenciNumara,
                Notlar = ogrenciNotlar
            };*/

            Console.WriteLine("\nPersonel Bilgilerini Girin:");
            Personel personel = PersonelBilgileriAl();
            /*Console.Write("Ad: ");
            string personelAd = Console.ReadLine();

            Console.Write("Soyad: ");
            string personelSoyad = Console.ReadLine();

            Console.Write("Görev: ");
            string personelGorev = Console.ReadLine();
           
            Personel personel = new Personel
            {
                Ad = personelAd,
                Soyad = personelSoyad,
                Gorev = personelGorev
            };*/

            /*double notOrtalamasi = Ogrenci.Ortalama(ogrenci.Notlar);

            Console.WriteLine($"\nÖğrenci Bilgileri:\nAd: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nNumara: {ogrenci.Numara}\nNot Ortalaması: {notOrtalamasi:F2}");

            Console.WriteLine($"\nPersonel Bilgileri:\nAd: {personel.Ad}\nSoyad: {personel.Soyad}\nGörev: {personel.Gorev}");*/
            Yazdir(ogrenci, personel);
        }
        static Ogrenci OgrenciBilgileriAl()
        {
            Console.WriteLine("Ad: ");
            string ogrenciAd = Console.ReadLine();

            Console.WriteLine("Soyad: ");
            string ogrenciSoyad = Console.ReadLine();

            Console.WriteLine("Numara: ");
            int ogrenciNumara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Notlar (tire(-) ile ayırarak girin): ");
            string[] notlarStr = Console.ReadLine().Split('-');
            int[] ogrenciNotlar = Array.ConvertAll(notlarStr, int.Parse);
            return new Ogrenci
            {
                Ad = ogrenciAd,
                Soyad = ogrenciSoyad,
                Numara = ogrenciNumara,
                Notlar = ogrenciNotlar
            };
        }

        static Personel PersonelBilgileriAl()
        {
            Console.WriteLine("Ad: ");
            string personelAd = Console.ReadLine();

            Console.WriteLine("Soyad: ");
            string personelSoyad = Console.ReadLine();

            Console.WriteLine("Görev: ");
            string personelGorev = Console.ReadLine();

            return new Personel
            {
                Ad = personelAd,
                Soyad = personelSoyad,
                Gorev = personelGorev
            };
        }

        static void Yazdir(Ogrenci ogrenci, Personel personel)
        {
            Console.WriteLine("\nÖğrenci Bilgileri:");
            Console.WriteLine($"Ad: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nNumara: {ogrenci.Numara}\nNot Ortalaması: {Ogrenci.Ortalama(ogrenci.Notlar):F2}");

            Console.WriteLine("\nPersonel Bilgileri:");
            Console.WriteLine($"Ad: {personel.Ad}\nSoyad: {personel.Soyad}\nGörev: {personel.Gorev}");
        }

    }
      
}
