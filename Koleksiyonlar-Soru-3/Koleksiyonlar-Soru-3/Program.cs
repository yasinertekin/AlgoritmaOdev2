using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Cümle Giriniz: ");
            ArrayList cümle = new ArrayList();
            ArrayList SesliHarfler = new ArrayList();
            ArrayList SessizHarfler = new ArrayList();
            string kelime = Console.ReadLine();
            cümle.Add(kelime);

            foreach (char item in kelime)
            {
                if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    SesliHarfler.Add(item);
                }
                else
                {
                    SessizHarfler.Add(item);
                }

            }


            SesliHarfler.Sort();
            Console.WriteLine("Sesli Harfler: ");

            foreach (var item in SesliHarfler)
            {
                Console.WriteLine(item);
            }

            SessizHarfler.Sort();
            Console.WriteLine("Sessiz Harfler: ");

            foreach (var item in SessizHarfler)
            {
                Console.WriteLine(item);
            }

        }
    }
}