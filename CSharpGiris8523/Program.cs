using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGiris8523
{
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ankara !");

            int sayi1; // declaration
            sayi1 = 7; //assignment , set
            sayi1 = 15;
            uint usayi1 = 256;
            Console.WriteLine("Sayı 1 : " + sayi1);

            //int sayi2 = 25;
            Int32 sayi2 = 25;

            Console.WriteLine(int.MaxValue + " - " + int.MinValue);
            Console.WriteLine("Max : {0}  -  Min {1} " , int.MaxValue , int.MinValue);

            long sayi3 = -123;
            ulong usayi3 = 126;
            Console.WriteLine("Sayı 3 : " + sayi3);

            short sayi4 = 32000;
            byte sayi5 = 0;

            Console.WriteLine("Sayı 4 : " + sayi4);
            Console.WriteLine("Sayı 5 : " + sayi5);

            bool durum = true;
            durum = false;
            Console.WriteLine("Durum : " + durum);

            char karakter = 'Z';
            Console.WriteLine(karakter + "  ASCII : " + (int)karakter); // casting

            double ondalik1 = -1.25;
            Console.WriteLine("Ondalık 1 : " +ondalik1);

            float ondalik2 = -1.75f;
            Console.WriteLine("Ondalık 2 : " +ondalik2);

            decimal ondalik3 = 3.72m;
            Console.WriteLine("Ondalık 3 : " +ondalik3);

            Console.WriteLine(Gunler.Pazartesi);

            #region Reference Types
            string adSoyad = "Okan Sabitoğulları";
            Console.WriteLine("Adı Soyadı : " +adSoyad);
            #endregion
            var sayi99 = 9.9;
            Console.WriteLine(sayi99);

            #region Escape Sequences (Escape Characters)
            string sehir ="\"Ankara\""; // "Ankara"
            Console.WriteLine(sehir);
            /*
             \" :Çift tırnak
            \n : new line(alt satır)
            \r : carriage return (satır başı) -- \n\r
            \\ :slash : C: \Program Files\Rockstar Games\GTA V
            \t :tab

            */
            string dosyaYolu;
            dosyaYolu = @"D:\ProgramFiles\Rockstar Games\GTA V";
            Console.WriteLine(dosyaYolu);
            #endregion
            Console.ReadLine();
        }
    }
}
