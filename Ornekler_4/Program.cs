using System;

namespace Ornekler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rakamla yazılan sayıyı harfe çeviren kod 

            string[] on = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] bir = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] grup = { "yüz", "bin", "milyon", "milyar", "sikim" };
            string sayi = "4588"; //rakamla yazılan sayı
            string yazi = "";
            int grpcount = -1;
            while (sayi.Length > 0)
            {
                string grp = "";
                bool k = true;
                while (k)
                {
                    grp = sayi[sayi.Length - 1] + grp;
                    sayi = sayi.Remove(sayi.Length - 1);
                    if (sayi.Length == 0 || grp.Length == 3) k = false;
                }
                while (grp.Length < 3) grp = "0" + grp;
                grpcount++;
                string grp_ = "";
                grp_ = bir[grp[2] - (byte)'0'];
                grp_ = on[grp[1] - (byte)'0'] + grp_; ;
                if (grpcount == 0)
                {
                    if (grp[0] != '0')
                        if (grp[0] == '1')
                            grp_ = grup[grpcount] + grp_;
                        else grp_ = bir[grp[0] - (byte)'0'] + grup[grpcount] + grp_;
                }
                else
                {
                    if (grp[0] != '0')
                        if (grp[0] == '1')
                            grp_ = grup[0] + grp_;
                        else
                            grp_ = bir[grp[0] - (byte)'0'] + grup[0] + grp_;
                    if (grp_ != "bir") grp_ = grp_ + grup[grpcount];
                    else if (grpcount <= 1) grp_ = grup[grpcount];
                    else grp_ = grp_ + grup[grpcount];
                }
                yazi = grp_ + yazi;
                

            }
            Console.WriteLine(yazi);
        }
    }
}
