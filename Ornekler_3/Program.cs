using System;


    class Program
    {
        static int Knapsack(int kapasite, int[] agirlik, int[] degerler, int n)
        {
            if (n == 0 || kapasite == 0) return 0;
            if (agirlik[n - 1] > kapasite) return Knapsack(kapasite, agirlik, degerler, n - 1);

            int dahilEtmeSonucu = degerler[n - 1] + Knapsack(kapasite - agirlik[n - 1], agirlik, degerler, n - 1);
            int haricBirakmaSonucu = Knapsack(kapasite, agirlik, degerler, n - 1);

            return Math.Max(dahilEtmeSonucu, haricBirakmaSonucu);

        }
        class Kenar
        {
            public int BaslangicDugum;
            public int HedefDugum;
            public int Uzaklik;
        }
        static void BellmanFord(int[,] graf, Kenar[] kenarlar, int baslangicDugum, int dugumSayisi, int KenarSayisi)
        {
            int[] mesafeler = new int[dugumSayisi];
            int[] oncekiDugumler = new int[dugumSayisi];
            for (int i = 0; i < dugumSayisi; i++)
            {
                mesafeler[i] = int.MaxValue;
                oncekiDugumler[i] = -1;
            }
            //baslangıç düğüm mesafesi 0 olacak
            mesafeler[baslangicDugum] = 0;
            //Tüm düğümleri dolaşarak en kısa yolları bul
            for (int i = 0; i < dugumSayisi; i++)
            {
                for (int j = 0; j < dugumSayisi; j++)
                {
                    int baslangic = kenarlar[j].BaslangicDugum;
                    int hedef = kenarlar[j].HedefDugum;
                    int uzaklik = kenarlar[j].Uzaklik;

                    //Mevuct düğümün mesafesi sonsuz değilse ve yeni yol daha kısa ise
                    if (mesafeler[baslangic] != int.MaxValue && mesafeler[baslangic] + uzaklik < mesafeler[hedef])
                    {
                        //kısa yolu güncelle
                        mesafeler[hedef] = mesafeler[baslangic] + uzaklik;
                        oncekiDugumler[hedef] = baslangic;
                    }
                }
            }

            //negatif döngü kontrol
            for (int i = 0; i < KenarSayisi; i++)
            {
                int baslangic = kenarlar[i].BaslangicDugum;
                int hedef = kenarlar[i].HedefDugum;
                int uzaklik = kenarlar[i].Uzaklik;

                //negatif döngü tespit edilirse
                if (mesafeler[baslangic] != int.MaxValue && mesafeler[baslangic] + uzaklik < mesafeler[hedef])
                {
                    Console.WriteLine("Negatif döngü bulundu. ");
                }
            }
            //ekrana yazdır 
            Console.WriteLine("DÜĞÜM         MESAFE        NEREDEN GELDİM");
            for (int i = 0; i < dugumSayisi; i++)
            {
                Console.WriteLine(i + "\t        " + mesafeler[i] + "\t           " + oncekiDugumler[i]);
            }

            Console.ReadLine();

        }
        static void Main(string[] args)
        {

            int dugumSayisi = 5;
            int kenarSayisi = 8;

            Kenar[] kenarlar = new Kenar[kenarSayisi];

            kenarlar[0] = new Kenar() { BaslangicDugum = 0, HedefDugum = 1, Uzaklik = -1 };
            kenarlar[1] = new Kenar() { BaslangicDugum = 0, HedefDugum = 2, Uzaklik = 4 };
            kenarlar[2] = new Kenar() { BaslangicDugum = 1, HedefDugum = 2, Uzaklik = 3 };
            kenarlar[3] = new Kenar() { BaslangicDugum = 1, HedefDugum = 3, Uzaklik = 2 };
            kenarlar[4] = new Kenar() { BaslangicDugum = 1, HedefDugum = 4, Uzaklik = 2 };
            kenarlar[5] = new Kenar() { BaslangicDugum = 3, HedefDugum = 2, Uzaklik = 5 };
            kenarlar[6] = new Kenar() { BaslangicDugum = 3, HedefDugum = 1, Uzaklik = 1 };
            kenarlar[7] = new Kenar() { BaslangicDugum = 4, HedefDugum = 3, Uzaklik = -3 };

            int baslangicDurum = 0;

            BellmanFord(new int[dugumSayisi, dugumSayisi], kenarlar, baslangicDurum, dugumSayisi, kenarSayisi);


            Console.ReadLine();
        }
    }

