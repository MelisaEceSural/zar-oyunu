using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181129ZarOyunuMetot
{
    class Program
    {
        static Random rnd = new Random();
        static double zar1()
        {
            double zar = rnd.Next(1, 21);
            return (zar * 5) / 100;
        }
        static int zar2()
        {
            return rnd.Next(1, 11);
        }
        static int zar3()
        {
            return rnd.Next(1, 5);
        }
        static int zar4()
        {
            return rnd.Next(1, 7);
        }
        static int zar5()
        {
            return rnd.Next(1, 9);
        }
        static int zar6()
        {
            return rnd.Next(1, 11);
        }
        static int zar7()
        {
            return rnd.Next(1, 13);
        }
        static double[] oyuncuPuanlar = { 100, 100 };
        static double[] Oynat(double[] oyuncuDizisi)
        {
            double puan = 0;
            
                for (int i = 0; i < 2; i++)
                {
                    double oran = zar1();
                    switch (zar2())
                    {

                        case 1:
                        case 2:
                            puan = oran * zar3();
                            break;
                        case 3:
                        case 4:
                            puan = oran * zar4();
                            break;
                        case 5:
                        case 6:
                            puan = oran * zar5();
                            break;
                        case 7:
                        case 8:
                            puan = oran * zar6();
                            break;
                        case 9:
                        case 10:
                            puan = oran * zar7();
                            break;
                    }
                    oyuncuDizisi[i] -= puan;
                    if (i == 0)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"{i + 1}. oyuncu zar attı.. Hasar= {puan}  Oyuncu yeni puanı= {oyuncuDizisi[i]}");
                    System.Threading.Thread.Sleep(500);
                } 
            
            return oyuncuDizisi;
        }
        static void Main(string[] args)
        {
            while (oyuncuPuanlar[0] > 0 && oyuncuPuanlar[1] > 0)
            {
                oyuncuPuanlar = Oynat(oyuncuPuanlar);
            }
            Console.ReadKey();
        }
    }
}
