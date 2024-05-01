using System;

namespace Ornekler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint sayi;
            uint maske;
            #region Sayının en sağdaki bitini değiştirme
            //sayi = 11;
            //// MSB...LSB
            //// sağdan itibaren ilk bitimiz 1 olsun
            //// sağ taraftaki ilk bit ya da en sağ bit
            //// 0 olarak değiştirelim  (diğer bitler zarar görmeyecek sadece ilk bit değişecek.)
            ////  x and 0 = 0 , x and 1 = x
            //// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  //Maskeye ihtiyacımız var
            //// 11111111111111111111111111111110  //Andleyeceğiz ve bu maskeyle diğer bitlere zarar vermeyeceğiz
            //// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0
            //maske = 0xfffffffe;  // = 1111 1111 1111 1111 1111 1111 1111 1110
            //sayi = sayi & (maske);
            //Console.WriteLine(sayi);
            #endregion
            #region sayının değilini almak
            //sayi = 0;
            //sayi = ~sayi; //sayının değilini almak
            //// 0000 .... 0000  -----> 1111 .... 1111
            //Console.WriteLine(sayi);
            #endregion

            #region Sayıyı orlamak ve andlemek
            //sayi = 98;
            //sayi = sayi | 0xf;
            //Console.WriteLine(sayi);

            //sayi = 98;
            //sayi = sayi & 0xf;
            //Console.WriteLine(sayi);
            #endregion

            #region Sola ve sağa shift
            //0101 sayısını sola shift edersek
            //1010 bir daha sola shift
            //0100 bir daha sola shit
            //1000 bir daha sola shift
            //0000
            //sola shift <<
            //sayi = 1;
            //sayi = sayi << 1; //1 bit sola shift ettim
            //Console.WriteLine(sayi);



            ////____4 bit sola shift____
            //sayi = 1;
            //for (int i = 0; i < 4; i++)
            //{
            //    sayi = sayi <<1;            //0001 {1} -> 0010{2} -> 0100{4} -> 1000{8} -> 1 0000 {16} 
            //    Console.WriteLine(sayi);   // 2li sayı sisteminde sola 1 br shift etmek 2 ile çarpmaktır
            //}




            ////____sayix2 ile sayi<<1 süre karşılaştırması____
            //Stopwatch sw = new Stopwatch();
            //sayi = 0;
            //sw.Start();

            //for (uint i = 0; i < 0xffffffff; i++)
            //{
            //    sayi = (uint)i;
            //    //sayi = sayi << 1;
            //    sayi = sayi * 2;
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            //Console.WriteLine(sayi);



            //________________________________SAĞA DOĞRU SHİFT________________________________
            //0101 sayısını sağa shift edersek
            //0010 bir daha sağa shift
            //0001 bir daha sağa shift
            //0000 bir daha sağa shift
            //0000
            //sağa shift >>
            //sayi = 8;
            //sayi = sayi >> 1;
            //Console.WriteLine(sayi);



            //____ 4 bit sağa shift____
            //sayi = 16;
            //for (int i = 0; i < 4; i++)
            //{
            //    sayi = sayi >> 1;               // 1 0000 {16} -> 1000 {8} -> 0100 {4} -> 0010 {2} -> 0001 {}1
            //    Console.WriteLine(sayi);        // 2li sayı sisteminde sağa 1 br shift etmek 2ye bölmektir.
            //}



            //// ____ sağ ve sol shiftfarkı ____;
            //sayi = 1;
            //for (int i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(sayi);
            //    sayi = sayi << 1;
            //}
            //Console.WriteLine("____________________________________________________");
            //sayi = 0xffffffff;
            //for (int i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(sayi);
            //    sayi = sayi >>1;
            //}



            //// ____ sayı tek mi çift mi ____ ?
            //sayi = 123;
            //if (sayi % 2 == 1) Console.WriteLine("tek");
            //else Console.WriteLine("çift");

            //if ((sayi & 0x1) == 1) { Console.WriteLine("tek"); }
            //else Console.WriteLine("çift");


            //if ((sayi >> 1) << 1 == sayi) Console.WriteLine("çift");
            //else Console.WriteLine("tek");



            #endregion

            //// ____ sayımızın ilk 2 bitini diğer bitlere zarar vermeden 1 yapalım
            //// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx11
            //// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  sayı
            //// 00000000000000000000000000000011  maske 
            //sayi = 4;
            //maske = 0x3;
            //sayi = sayi | maske;
            //Console.WriteLine(sayi);


            //// sayının 3.bit 1, 9.bit 0, 12.bit 1 ve 28.bit 0 yapalım
            //// 3,12 = 1 olacak            9,28=0 olacak
            //// 1000 0000 0100 =804; orlucaz      1111 0111 1111 1111 1111 1110 1111 1111 andlicez
            //// xxxx xxxx xxxx xxxx xxxx xxxx xxxx xxxx  sayı
            //// 
            //sayi = 512;
            //maske = 0x804;
            //sayi = sayi | maske;
            //maske = 0xf7fffeff;
            //sayi = sayi & maske;
            //Console.WriteLine(sayi);



            //ÖRNEK _______ sayi değişkenimizin içerisideki bit değeri 1 olanların sayısı
            //sayi = 1535;
            //maske = 1;     
            //int adet = 0;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((sayi & maske) !=0) adet++;
            //    maske = maske << 1;
            //}
            //Console.WriteLine(adet);


            //ÖRNEK _______ sayiyi ikili sayı sistemine dönüştürelim
            //sayi = 0xf0f0f0f0;
            //string s = "";
            //maske = 0x80000000;
            //for (int i = 0; i < 32; i++)
            //{
            //       if ((sayi & maske) != 0) s = s+"1";
            //       else s = s+"0";
            //    maske = maske >> 1;
            //}
            //Console.WriteLine(s);

            #region a ve b sayıları aynı mı değil mi 
            //11110
            //11100
            //uint a = 19;
            //uint b = 19;

            //ÇÖZÜM 1
            //int c = 0;
            //Console.WriteLine(EsitMi(a,b));
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & 1) == (b & 1)) c++;
            //    a = a >> 1;b = b >> 1;
            //}
            //if (c == 32) Console.WriteLine("Eşit");
            //else Console.WriteLine("Değil");

            //ÇÖZÜM  2
            //uint temp = a & b;
            //if (temp == a && temp == b) Console.WriteLine("Eşit");
            //else Console.WriteLine("Değil");

            #endregion

            #region a sayısının ilk 4 bitini ekrana 10luk sayi sisteminde yazdıralım
            //uint a = 0xef000000;

            ////Çözüm 1
            ////a = a >> 28; Console.WriteLine(a);
            ////Çözüm 2
            ////uint b = a & 0xf0000000; b = b >> 28; Console.WriteLine(b);
            ////Çözüm 3
            //uint b = 0;
            //uint c = 0x8; // en yüksek seviye için maske=0x80000000,, en düşük seviye(en sağdaki) için 0x00000008
            //for (int i = 0; i < 4; i++)
            //{
            //    if ((a & 0x80000000) != 0) b = b | c;
            //    else b=b&~c;
            //    a <<= 1; c >>= 1;
            //}
            ////b = b >> 28;
            //Console.WriteLine(b);
            #endregion

            #region a sayısının 13,14,15,16. bitlerini ekrana 10luk yazdır
            //uint a = 0xffeeddcc;
            //uint b = 0;
            //uint c = 0x8;
            //for (int i = 0; i < 4; i++)
            //{
            //    if ((a & 0x8000) != 0) b = b | c;
            //    else b = b & ~c;
            //    a <<= 1; c >>= 1;
            //}
            ////b = b >> 28;
            //Console.WriteLine(b);
            #endregion

            #region a sayısının hex olarak sağdan dördüncü rakamını b sayısının en soldan birinci rakamına taşıyınız
            //uint a = 0xffee0dcc;
            //uint b = 0;
            //uint c = 0x80000000; 
            //for (int i = 0; i < 4; i++)
            //{
            //    if ((a & 0x8000) != 0) b = b | c;
            //    else b = b & ~c;
            //    a <<= 1; c >>= 1;
            //}
            //Console.WriteLine(b);
            #endregion;

            #region bit sayısı adetini recursive bulma
            //int adet = 0;
            //uint sayi = 0xf000000f;
            //uint maske = 1;
            //for (int i = 0; i < 32; i++)
            //{
            //    //if ((sayi & maske) == 1) adet++;
            //    //sayi >>= 1;

            //    if ((sayi & maske) != 0) adet++;
            //    maske <<= 1;
            //}
            //Console.WriteLine(adet);
            //Console.WriteLine(bitSayisiRecursiveBir(sayi));
            //Console.WriteLine(bitSayisiRecursive(sayi, maske));
            #endregion


            //Shift işlemleri -kaydırma- << >>

            // sağa doğru shit sayının 2 ile bölünmesi demektir.

            //uint b = 0x80000000;
            //for (int i = 0; i < 32; i++)
            //{
            //    Console.WriteLine(b);
            //    b = b >> 1;
            //}

            #region a sayısının içerisindeki değerin ikilik sayı sistemindeki karşılığını bulunuz
            //uint a = 32;
            //string s = "";
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & 1) == 1) s =  "1"+s;
            //    else s = "0"+s;
            //    a = a >> 1;
            //}
            //Console.WriteLine(s);
            #endregion

            #region a sayısının içerisinde kaç adet binary 1 olan bit vardır 
            //uint sayi = 112;
            //uint mask = 1;
            //int adet = 0;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((sayı & 1) == 1) adet++;
            //    sayı = sayı >> 1;                //bu işlemde sayıyı değerini bozuyoruz o yüzden alttaki çözüm daha ii.

            //    if ((sayi & mask) == mask) adet++;  //veya if((sayi&mask)!=0) daha kısa kodla çalışır.
            //    mask <<= 1;
            //}
            //Console.WriteLine(adet);
            #endregion

            #region tek mi çift mi
            //Console.WriteLine(((sayi1 >> 1) << 1) != sayi1 ? "tek" : "çift");
            #endregion

            #region bir kümenin elemanları 1 ile 10 arasındadır bu kümenin tüm alt kümelerinden alt küme toplamı 22 olan kaç adet alt küme vardır
            //int[] kume = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int k = 1;
            //int adet = 0;
            //int toplam = 0;
            //for (int i = 1; i < 1024; i++)                      //bütün kümelerimin alt küme sayısı
            //{
            //    k = 1;
            //    toplam = 0;
            //    for (int j = 0; j < 10; j++)                    //kümenin eleman sayısı
            //    {
            //        if ((i & k) != 0) toplam += kume[j];                      //Console.Write(kume[j]);
            //        k <<= 1;
            //    }
            //    //Console.WriteLine("");
            //    if (toplam == 22) adet++;
            //}
            //Console.WriteLine(adet);
            #endregion

            #region 10 elemanlıda toplamı 10 olan alt kümeleri ekrana yazdır
            //int[] kume = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int k = 1;
            //int adet = 0;
            //int toplam = 0;
            //for (int i = 1; i < 1024; i++)                      //bütün kümelerimin alt küme sayısı
            //{
            //    k = 1;
            //    toplam = 0;
            //    for (int j = 0; j < 10; j++)                    //kümenin eleman sayısı
            //    {
            //        if ((i & k) != 0) toplam += kume[j];                   //Console.Write(kume[j]);
            //        k <<= 1;
            //    }
            //    //Console.WriteLine("");
            //    if (toplam == 10)
            //    {
            //        adet++;
            //        k = 1;
            //        for (int j = 0; j < 10; j++)
            //        {
            //            if ((i & k) != 0) Console.Write(kume[j]);

            //            k <<= 1;
            //        }
            //        Console.WriteLine("");
            //    }
            //}
            //Console.WriteLine("adet: " + adet);
            ////100 elemanlı deseydik olmazdı çünkü
            ////114.satırdaki foru 100 kez döndürmen lazım fakat 100 biti olan sayımız yok
            ////longu kullanırsan 64 bit olduğu için 64e kadar gidersin
            ////başka çözüm oluşturman lazım
            
            #endregion

        }

        static uint bitSayisiRecursiveBir(uint sayi)
        {
            if (sayi == 0) return 0;
            return (sayi & 1) + bitSayisiRecursiveBir(sayi >> 1);
        }
    }
}
