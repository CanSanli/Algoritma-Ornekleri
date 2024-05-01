using System;

namespace Ornekler
{
    class Program
    {

        static void Main(string[] args)
        {

            //Örn.1 - Kullanıcının girdiği uzunlukta fibonacci serisini yazdır

            //fibonacci(Convert.ToInt32(Console.ReadLine()));
            //------------------------------------------------------------------------

            //Örn.2 - Recursive fibonacci
            #region örn2-çözüm
            //Console.Write("dizi uzunluğu: ");
            //int len = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine($"{recursiveFibonacci(i)}");
            //}
            #endregion
            //------------------------------------------------------------------------

            //Örn.3 - Kullanıcının girdiği sayı dizideki hangi elemana denk geliyorsa onu yaz
            #region örn3-çözüm
            //Console.Write("Sayı gir: ");
            //int num = Int32.Parse(Console.ReadLine());
            //fibonacci_orn3(num);
            #endregion
            //------------------------------------------------------------------------

            //Örn.4 - Girilen sayının basamaklarını toplayan recursive yapı
            #region örn4-çözüm
            //    Console.WriteLine("sayı: ");
            //    int x = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine(RecursiveBasamakTopla(x));
            #endregion
            //------------------------------------------------------------------------

            //Örn.5 - A dizisinin içinde b dizisi var mı 
            #region örn5-çözüm
            //int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] b = new int[] { 2,3,4,5 };
            //if (DizideMevcutMu(a, b))
            //{
            //    Console.WriteLine("mecvut");
            //}
            #endregion
            //------------------------------------------------------------------------

            //Örn.6 - Bir A dizisinin elemanlarını sağa kaydır
            #region örn6-çözüm
            //int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (var num in a)
            //{
            //    Console.WriteLine(num);
            //}
            //DiziyiKaydir(a);
            //foreach (var num in a)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            //------------------------------------------------------------------------

            //Örn.7 - Bir A dizisinin elemanlarını n kere sağa kaydır
            #region örn7-çözüm
            //int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //NKereSagaKaydır(a, 15);
            //foreach (var x in a)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            //------------------------------------------------------------------------

            //Örn.8 - Elimizdeki dizi sonlu aritmetik dizi mi ? (elemanlar arası fark eşit, en az 3 eleman)
            #region örn8-çözüm
            //int[] a = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //if (AritmetikMi(a))
            //{
            //    Console.WriteLine("aritmetik");
            //}
            #endregion
            //------------------------------------------------------------------------

            //Örn.9 - Dizinin içindeki aritmetik dizilerden en uzun olanı bulan
            int[] a = new int[] { 1, 2, 3, 4, 5, 2, 4, 6, 5, 10, 15, 20, 25, 30, 35, 40 };
            EnUzunAritmetikDizi(a);

        }

        #region örn 1
        static void fibonacci(int x)
        {
            int num1 = 0;
            int num2 = 1;
            int t = 0;
            if (x == 0)
            {
                Console.WriteLine("!");
            }
            else if (x == 1)
            {
                Console.WriteLine("0");
            }
            else
            {

                Console.Write(num1 + " ");
                Console.Write(num2);
                for (int i = 2; i < x; i++)
                {
                    t = num1 + num2;
                    Console.Write(" " + t);
                    num1 = num2;
                    num2 = t;
                }
            }

        }
        #endregion
        #region örn 2
        static int recursiveFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return recursiveFibonacci(n - 1) + recursiveFibonacci(n - 2);

        }
        #endregion
        #region örn 3
        static void fibonacci_orn3(int x)
        {
            int num1 = 0;
            int num2 = 1;
            int t = 0;
            if (x == 0)
            {
                Console.WriteLine("!");
                return;
            }
            else if (x == 1) t = 1;
            else
            {
                for (int i = 2; i < x; i++)
                {
                    t = num1 + num2;
                    num1 = num2;
                    num2 = t;
                }

            }
            Console.WriteLine(t);
        }
        #endregion
        #region örn 4
        static int RecursiveBasamakTopla(int num)
        {
            if (num != 0)
            {
                return num % 10 + RecursiveBasamakTopla(num / 10);
            }
            else return 0;
        }
        #endregion
        #region örn 5
        static bool DizideMevcutMu(int[] a, int[] b)
        {
            int aLen = a.Length;
            int bLen = b.Length;
            bool flag = true;
            bool flag2 = false;
            if (aLen >= bLen)
            {
                for (int i = 0; i <= aLen - bLen; i++)
                {
                    if (a[i] == b[0])
                    {
                        flag2 = true;
                        for (int j = 0; j < bLen; j++)
                        {
                            if (a[i + j] != b[j])
                            {
                                flag = false;
                                break;
                            }
                        }

                    }

                }
                if (!flag2)
                {
                    flag = false;
                }

            }
            else flag = false;
            return flag;
        }
        #endregion
        #region örn 6
        static void DiziyiKaydir(int[] a)
        {
            int diziLength = a.Length;
            int sonEleman = a[diziLength - 1];
            for (int i = diziLength - 1; i >= 1; i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = sonEleman;

        }
        #endregion
        #region örn 7 
        static void NKereSagaKaydır(int[] a, int n)
        {

            for (int j = 0; j < n % a.Length; j++)
            {
                int sonEleman = a[a.Length - 1];
                for (int i = a.Length - 1; i >= 1; i--)
                {
                    a[i] = a[i - 1];
                }
                a[0] = sonEleman;
            }

        }
        #endregion
        #region örn 8
        static bool AritmetikMi(int[] a)
        {
            int ortakFark = Math.Abs(a[1] - a[0]);
            bool flag = true;
            if (a.Length >= 3)
            {
                for (int i = 2; i < a.Length; i++)
                {
                    if (Math.Abs(a[i - 1] - a[i]) != ortakFark)
                    {
                        flag = false;
                        break;
                    }

                }
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        #endregion

        static void EnUzunAritmetikDizi(int[] a)
        {
            int ortakFark = 0;
            int zincir = 1;
            int maxZincir = 0;
            int bas = 0;

            try
            {
                for (int i = 1; i < a.Length; i++)
                {
                    ortakFark = Math.Abs(a[i - 1] - a[i]); //1 
                    for (int j = i; j < a.Length; j++)
                    {

                        if (j == a.Length - 1)
                        {
                            if (Math.Abs(a[j - 1] - a[j]) == ortakFark)
                            {
                                zincir++;
                                bas = i - 1;
                                maxZincir = zincir;
                                i = 15;
                                break;
                            }
                        }
                        else if (Math.Abs(a[j - 1] - a[j]) == ortakFark)
                        {
                            zincir++;
                        }
                        else
                        {

                            if (maxZincir < zincir)
                            {
                                bas = i - 1;
                                maxZincir = zincir;
                                i = maxZincir;
                            }

                            zincir = 0;

                            break;
                        }
                    }


                }

            }
            catch (Exception)
            {

                throw;
            }
            for (int i = bas; i < maxZincir; i++)
            {
                Console.WriteLine(a[i]);
            }

            //}

        }
    }
}
