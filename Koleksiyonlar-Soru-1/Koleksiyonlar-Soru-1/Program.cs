using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList GirilenSayilar = new ArrayList();
            //ArrayList Sayilar = new ArrayList() { 2, 3,5,7,11};
            ArrayList AsalSayilar = new ArrayList();
            ArrayList AsalDegil = new ArrayList();

            Console.WriteLine("Lütfen 20 tane sayı giriniz: ");
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    GirilenSayilar.Add(sayi);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen Numeric veya Pozitif bir değer giriniz!!");
            }

            

            foreach (int Girdi in GirilenSayilar)
            {
                if (Girdi < 0)
                {
                    Console.WriteLine("Lütfen Numeric veya Pozitif bir değer giriniz!!");
                    break;
                }

                if (Girdi == 2 || Girdi == 3 || Girdi == 5 || Girdi == 7 || Girdi == 11)
                {
                    AsalSayilar.Add(Girdi);
                }

                else if (Girdi % 2 == 0 || Girdi % 3 == 0 || Girdi % 5 == 0 || Girdi % 7 == 0 || Girdi % 10 == 0 || Girdi % 11 ==0 || Girdi == 1 || Girdi == 0)
                {
                    AsalDegil.Add(Girdi);
                }

                else
                {
                    AsalSayilar.Add(Girdi);
                }
            }
            Console.WriteLine("                              ");
            Console.WriteLine("******Asal Sayiar***********");
            foreach (var item in AsalSayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("                                    ");
            Console.WriteLine("*******Asal Olmayan Sayılar********");

            foreach (var item in AsalDegil)
            {
                Console.WriteLine(item);
            }

            AsalSayilar.Sort();
            AsalSayilar.Reverse();

            Console.WriteLine("**********Asal Sayıların Büyükten Küçüğe Sıralaması*********");
            foreach (var item in AsalSayilar)
            {
                Console.WriteLine(item);
            }
            AsalDegil.Sort();
            AsalDegil.Reverse();
            Console.WriteLine("****************Asal olmayan Sayıların Büyükten Küçüğe Sıralaması***************");

            foreach (var item in AsalDegil)
            {
                Console.WriteLine(item);
            }
            int AsalTop = 0;
            int AsalDegilTop = 0;

            foreach (int item in AsalSayilar)
            {
                AsalTop = AsalTop + item;
                
            }
            Console.WriteLine("Asal Sayıların Toplamı: " + AsalTop);

            foreach (int item in AsalDegil)
            {
                AsalDegilTop = AsalDegilTop + item;
            }
            Console.Write("Asal Olmayan Sayıların Toplamı: " + AsalDegilTop);
            Console.WriteLine("                                             ");
            Console.Write(AsalSayilar.Count + " tane asal sayı vardır");
            Console.WriteLine("                                             ");
            Console.Write(AsalDegil.Count + " tane asal olmayan sayı vardır");
        }
    }
}