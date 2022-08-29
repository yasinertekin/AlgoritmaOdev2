using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Sayiler = new ArrayList();
            ArrayList BüyükSayilar = new ArrayList();
            ArrayList KüçükSayilar = new ArrayList();
            int KüçükTop = 0;
            int BüyükTop = 0;
            int KüçükOrt = 0;
            int BüyükOrt = 0;


            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());

                    if (sayi > 0)
                    {
                        Sayiler.Add(sayi);
                    }

                    else
                    {
                        Console.WriteLine("Lütfen Pozitif Bir Değer Giriniz!!!");
                        break;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen Numeric Bir Değer Giriniz");
            }

            Sayiler.Sort();
            KüçükSayilar.Add(Sayiler[0]);
            KüçükSayilar.Add(Sayiler[1]);
            KüçükSayilar.Add(Sayiler[2]);



            Console.WriteLine("Küçük Sayıların Ortalaması: ");
            foreach (int item in KüçükSayilar)
            {
                KüçükTop = KüçükTop + item;
                KüçükOrt = KüçükTop / 3;
                
            }
            Console.WriteLine(KüçükOrt);

            Sayiler.Reverse();
            BüyükSayilar.Add(Sayiler[0]);
            BüyükSayilar.Add(Sayiler[1]);
            BüyükSayilar.Add(Sayiler[2]);


            Console.WriteLine("Büyük Sayıların Ortalaması: ");
            foreach (int item in BüyükSayilar)
            {
                BüyükTop = BüyükTop + item;
                BüyükOrt = BüyükTop / 3;
                
            }
            Console.WriteLine(BüyükOrt);
            int GenelOrt = BüyükOrt + KüçükOrt;

            Console.Write("Ortalamalarının Toplamı: " + GenelOrt);








            Console.ReadKey();
        }
    }
}

