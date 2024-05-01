using System;

namespace Ornekler_9
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Elimizde 50,20,5,1 litrelik hacimlere sahip sınırsız şişe olduğunu varsayalım.
                    * Belli bir miktarda zeytinyağı bu şişeler kullanılarak paketlenecektir.
                    * Bu zeytinyağını minimum şişe kullanımıyla paketlenmesi gerekmektedir.
                    * Yazacağınız program kendisine zeytinyağının litre bilgisini parametre olarak
                    * alacak ve ekrana paketleme işlemi sonrasında hangi hacimdeki şişeden kaç adet
                    * kullanıldığını basacaktır */
            MinimumSiseKullanimi(2476);
        }

          

        static void MinimumSiseKullanimi(int zeytinyagiLitresi)
        {
            int adet50L = zeytinyagiLitresi / 50;
            zeytinyagiLitresi %= 50;
            int adet20L = zeytinyagiLitresi / 20;
            zeytinyagiLitresi %= 20;
            int adet5L = zeytinyagiLitresi / 5;
            zeytinyagiLitresi %= 5;
            int adet1L = zeytinyagiLitresi / 1;
            zeytinyagiLitresi %= 1;

            Console.WriteLine("50 Litrelik şişe : {0}", adet50L);
            Console.WriteLine("20 Litrelik şişe : {0}", adet20L);
            Console.WriteLine("5 Litrelik şişe : {0}", adet5L);
            Console.WriteLine("1 Litrelik şişe : {0}", adet1L);
        }
    }
}
