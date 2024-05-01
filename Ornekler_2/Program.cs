using System;


    class Program
    {
        #region Dizi Aritmetik midir? Boyut en az 3 olmalı
        static int SonluAritmetikDiziMi(int[] A)
        {
            int ortakFark = 1;
            int sonuc = 0;
            int diziBoyutu = A.Length;
            if (diziBoyutu >= 3)
            {
                ortakFark = A[1] - A[0];
                for (int i = 3; i < A.Length; i++)
                {
                    if ((A[i] - A[i - 1]) != ortakFark) { sonuc = 0; break; }
                    else sonuc = 1;
                }
            }
            return sonuc;
        }
        #endregion

        #region Elimizdeki dizinin içerisindeki en uzun aritemetik diziyi bul
        private static int EnUzunAritmetikDiziBul(int[] A, int altSinir, int ustSinir)
        {
            int diziBoyutu = A.Length;
            int sonuc = 0;
            int ortakFark = 1;
            if (altSinir >= 0 && (ustSinir < diziBoyutu) && (ustSinir - altSinir + 1) >= 3)
            {
                ortakFark = A[altSinir + 1] - A[altSinir];
                int i = altSinir + 2;
                for (; i < ustSinir; i++)
                {
                    if ((A[i] - A[i - 1]) != ortakFark) { sonuc = 0; break; }
                    else sonuc = 1;
                }
            }
            return sonuc;
        }

        #endregion
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 7, 9, 10, 13 };
            //Console.WriteLine(SonluAritmetikDiziMi(A));

            int[] C = { 26, 44, 11, 2, 4, 6, 8, 10, 12, 14, 16, 3, 6, 9, 12, 15, 18, 21, 5, 10, 15, 7 };
            int diziBoyutu = C.Length;
            int altSinir = 0;
            int ustSinir = 0;
            int maksZincirUz = 1;
            int zincirUz;
            for (int i = 0; i < diziBoyutu - 2; i++)
            {
                for (int j = i + 2; j < diziBoyutu; j++)
                {
                    if (EnUzunAritmetikDiziBul(C, i, j) == 1)
                    {
                        zincirUz = (j - i + 1);
                        if (zincirUz > maksZincirUz)
                        {
                            maksZincirUz = zincirUz;
                            altSinir = i;
                            ustSinir = j;
                        }
                    }
                }
            }
            for (int i = altSinir; i < ustSinir; i++)
            {
                Console.WriteLine(C[i] + "  ");
            }
            Console.ReadKey();
        }
    }

