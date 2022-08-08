using System;
using System.Collections.Generic;

namespace CS101_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odev1 odev1 = new Odev1();
            //odev1.LogNumbers();

            //Odev2 odev2 = new Odev2();
            //odev2.LogNumbers();

            //Odev3 odev3 = new Odev3();
            //odev3.LogReverseWords();


        }
    }

    class Odev1
    {
        int n = 1;
        
        public void LogNumbers()
        {
            List<int> numbers = new List<int>();
        a1:
            Console.WriteLine("Pozitif bir sayı giriniz.");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("n: " + n);
            }
            catch
            {
                throw new Exception("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }
            if (n < 1)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }
            for (int i = 0; i < n; i++)
            {
            a2:
                Console.WriteLine(i+1 + ". Pozitif sayıyı giriniz.");
                try
                {
                    var sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 1)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        goto a2;
                    }
                    numbers.Add(sayi);
                }
                catch
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                    goto a2;
                }
                
                
            }
            Console.WriteLine("Çift Sayılar");
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

    class Odev2
    {
        int n = 1;
        int m = 1;
        List<int> numbers = new List<int>();
        public void LogNumbers()
        {
            List<int> numbers = new List<int>();
        a1:
            Console.WriteLine("Pozitif bir sayı giriniz.");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("n: " + n);
            }
            catch
            {
                throw new Exception("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }
            if (n < 1)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }

        a2:
            Console.WriteLine("Pozitif bir sayı giriniz.");
            try
            {
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("m: " + m);
                if (m < 1)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                    goto a2;
                }
            }
            catch
            {
                throw new Exception("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }
            for (int i = 0; i < n; i++)
            {
            a3:
                Console.WriteLine(i + 1 + ". Pozitif sayıyı giriniz.");
                try
                {
                    var sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 1)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        goto a3;
                    }
                    numbers.Add(sayi);
                }
                catch
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                    goto a3;
                }


            }
            Console.WriteLine("m'ye eşit olanlar ya da tam bölünenler");
            foreach (var item in numbers)
            {
                if (item%m==0 || item==m)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    class Odev3 
    {
        int n = 1;
        string kelime = "";

        public void LogReverseWords()
        {
            List<string> words = new List<string>();
            List<string> words2 = new List<string>();
        a1:
            Console.WriteLine("Pozitif bir sayı giriniz.");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("n: " + n);
            }
            catch
            {
                throw new Exception("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }
            if (n < 1)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                goto a1;
            }
            for (int i = 0; i < n; i++)
            {
            a2:
                Console.WriteLine(i + 1 + ". Kelimeyi giriniz.");
                try
                {
                    kelime = Console.ReadLine().ToString();
                    
                }
                catch
                {
                    Console.WriteLine("Lütfen bir kelime giriniz");
                    goto a2;
                }
                finally 
                {
                    char[] c = kelime.ToCharArray();
                    var a = "";
                    for (int j = c.Length-1; j >= 0; j--)
                    {
                        a += c[j].ToString();
                    }
                    Console.WriteLine(a);
                }
            }
            
        }
    }
    
}
