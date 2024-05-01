using System;

namespace Ornekler_8
{
    class Program
    {
        class HuffmanBtree
        {
            public int frekans;  //  tutucak
            public int character;  // hangi karaktere ait olduğu tutucak
            public string huffman;  //010101 tutucak
            public HuffmanBtree left;
            public HuffmanBtree right;
        }
        static void CreateHuffmanTree(HuffmanBtree[] hbt)
        {

            if (hbt[1] == null) return;
            HuffmanBtree b = new HuffmanBtree();
            b.left = hbt[0];
            b.right = hbt[1];
            b.frekans = hbt[0].frekans + hbt[1].frekans;


            hbt[0] = b;
            hbt[1] = null;


            Array.Sort(hbt, (object x, object y) =>
            {

                int a = 0;
                if (x == null && y == null) return 0;
                if (x == null) return 1; if (y == null) return -1;
                if (((HuffmanBtree)x).frekans < ((HuffmanBtree)y).frekans) a = -1;
                if (((HuffmanBtree)y).frekans < ((HuffmanBtree)x).frekans) a = 1;
                return a;
            });
            CreateHuffmanTree(hbt);
        }
        static void RedirectHuffmanTree(HuffmanBtree hbt, string yon)
        {
            if (hbt == null) return;

            if (hbt.left == null) hbt.huffman = yon;
            RedirectHuffmanTree(hbt.left, yon + "1");
            if (hbt.right == null) hbt.huffman = yon;
            RedirectHuffmanTree(hbt.right, yon + "0");
        }
        static void ShowHuffmanCodes(HuffmanBtree hbt)
        {
            if (hbt == null) return;
            if (hbt.left == null) Console.WriteLine("{0}  {1}", (char)hbt.character, hbt.huffman);  // en alta geldim, leaf level'ı buldum demek
            ShowHuffmanCodes(hbt.left);
            ShowHuffmanCodes(hbt.right);
        }

        static string FindHuffman(HuffmanBtree hbt, int character)
        {
            if (hbt == null) return "";
            if (hbt.character == character) return hbt.huffman;
            return FindHuffman(hbt.left, character) + FindHuffman(hbt.right, character); 
        }
        static string HuffmanDecode(HuffmanBtree hbt, string packeddata)
        {
            HuffmanBtree currentNode = hbt;
            string result = "";

            for (int i = 0; i < packeddata.Length; i++)
            {
                char data = packeddata[i];

                if (data == '0')
                {
                    currentNode = currentNode.left;
                }
                else if (data == '1')
                {
                    currentNode = currentNode.right;
                }

                if (currentNode.left == null && currentNode.right == null)
                {
                    result += (char)currentNode.character;
                    currentNode = hbt;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {

            string s1 = "aabcaabbabc";
            int[] frekans = new int[5];

            HuffmanBtree[] hbt = new HuffmanBtree[5];

            for (int i = 0; i < s1.Length; i++)
            {
                frekans[s1[i] - 'a']++;
            }
            for (int i = 0; i < 3; i++)
            {
                hbt[i] = new HuffmanBtree();
                hbt[i].frekans = frekans[i];
                hbt[i].character = 'a' + i;
            }


            Array.Sort(hbt, (object x, object y) =>
            {

                int a = 0;
                if (x == null && y == null) return 0;
                if (x == null) return 1; if (y == null) return -1;
                if (((HuffmanBtree)x).frekans < ((HuffmanBtree)y).frekans) a = -1;
                if (((HuffmanBtree)y).frekans < ((HuffmanBtree)x).frekans) a = 1;
                return a;
            });

            CreateHuffmanTree(hbt);

            RedirectHuffmanTree(hbt[0], "");
            ShowHuffmanCodes(hbt[0]);


            string packeddata = "";
            for (int i = 0; i < s1.Length; i++)
            {
                packeddata += FindHuffman(hbt[0], s1[i]);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Sıkıştırılmış veri : " + packeddata);

            Console.WriteLine("Geri Açılmış Veri: {0}", HuffmanDecode(hbt[0], packeddata));


            Console.ReadLine();
        }
    }
}
