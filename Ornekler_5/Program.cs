using System;

namespace Ornekler_5
{
    class Program
    {

        static void Main(string[] args)
        {
            //Automota Örnekleri

            //11 den sonra 00 ya da 01 

            //string s = "1100111001010";
            //int[,] q = new int[6, 2];
            //q[0, 0] = 0; q[0, 1] = 1;
            //q[1, 0] = 0; q[1, 1] = 2;
            //q[2, 0] = 3; q[2, 1] = 5;
            //q[3, 0] = 0; q[3, 1 ]=4;
            //q[4, 0] = 4; q[4, 1] = 4;
            //q[5, 0] = 0; q[5, 1] = 4;
            //int state = 0;
            //string finalstate = "01";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    state = q[state, s[i] - (byte)'0'];

            //}
            //if (finalstate.IndexOf(state.ToString()) == -1) Console.WriteLine("Onaylanmadı");
            //else Console.WriteLine("ONAY");

            //++++++++++++++++++++++++++++++++++++++++++++++++++++

            //aa dan sonra cb veya b
            //string s = "abcaacbac";
            //int[,] q = new int[5, 3];
            //q[0, 0] = 1; q[0, 1] = 0; q[0, 2] = 0;
            //q[1, 0] = 2; q[1, 1] = 0; q[1, 2] = 0;
            //q[2, 0] = 4; q[2, 1] = 0; q[2, 2] = 3;
            //q[3, 0] = 4; q[3, 1] = 0; q[3, 2] = 4;
            //q[4, 0] = 4; q[4, 1] = 4; q[4, 2] = 4;
            //int state = 0;
            //string finalState = "01";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    state = q[state, s[i] - (byte)'a'];
            //}
            //if (finalState.IndexOf(state.ToString()) == -1) Console.WriteLine("Onaylanmadı");
            //else Console.WriteLine("ONAY");

            #region dinamik harf alan sabit substring arama
            //Console.WriteLine("Harf veya kelime gir (x -> çıkış)");
            //string yazi = "";
            //string aranan = "gg";            //g = 6
            //int[,] q = new int[3, 30];
            //Console.WriteLine('s' - 'a');
            //q[0, 6] = 1;


            //for (int i = 0; i < 30; i++)
            //{
            //    q[1, i] = 0;
            //}

            //q[1, 6] = 2;


            //bool flag = false;
            //while (!flag)
            //{
            //    int state = 0;
            //    string temp = Console.ReadLine();
            //    if (temp.Contains("x"))
            //    {
            //        if (state != 2) Console.WriteLine("çıkış yapılıyor -> x");
            //        flag = true;
            //        continue;
            //    }
            //    yazi += temp;
            //    Console.Write("güncel metin -> " + yazi);

            //    for (int i = 0; i < yazi.Length; i++)
            //    {
            //        state = q[state, yazi[i] - 'a'];
            //    }
            //    if (state == 2)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("aranan metin (gg) bulundu");
            //        flag = true;
            //        continue;
            //    }




            //}
            //Console.WriteLine("çıktı");
            #endregion

            #region her ab'den sonra en az 1 tane c olacak
            // her ab'den sonra en az 1 tane c olacak
            // en az bir defa bu pattern gelecek

            // q0    a    q1
            // q1    a    q1, b    q2, diğer durumda   q0
            // q2    kesinlikle c gelirse q0
            // q3    c gelebilir ve 

            //string s1 = "abaadfabcabc";
            //int[,] q = new int[3, 10];
            //int state = 0;
            //q[0, 0] = 1;
            //q[1, 0] = 1;
            //q[1, 1] = 2;
            //for (int i = 0; i < 10; i++)
            //{
            //    q[2, i] = 3;
            //}
            //q[2, 2] = 0;
            //int flag = 0;
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    state = q[state, s1[i] - 'a'];
            //    if (state == 2) flag = 1;
            //    if (state==3){ flag = 0; Console.WriteLine("Dead State"); break; }
            //}
            //if (flag == 1) Console.WriteLine("Var Kanks");
            //else Console.WriteLine("Yok Kanks");
            #endregion

            #region  3 tane 0 ard arda gelirse kabul etmeyen dfa
            // 3 tane 0 ard arda gelirse kabul etmeyen dfa
            //string s1 = "0011110010100011";
            //int[,] q = new int[4,2];
            //int state = 0;
            //q[0, 0] = 1;
            //q[0, 1] = 0;

            //q[1, 0] = 2;
            //q[1, 1] = 0;

            //q[2, 0] = 3;
            //q[2, 1] = 0;
            //q[3, 0] = 3;
            //q[3, 1] = 3;

            //for (int i = 0; i < s1.Length; i++)
            //{
            //    state = q[state, s1[i] - '0'];
            //}
            //if (state == 3) Console.WriteLine("DeadState");
            #endregion
        }



    }
}
