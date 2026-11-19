namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static Random r = new Random();
        static void F01()
        {
            for (int i = 0; i < sorokSzama; i++) // sorokon megy végig
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    szamokMatrix[i, j] = r.Next(10, 100);
                }
            }
        }
        static void F02()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Console.Write(szamokMatrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void F03()
        {
            int ossz = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
            }
                Console.WriteLine($"A mátrixba lévő elemek összege {ossz}");
        }
        static void F04()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                int ossz = 0;
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"A mátrix {i+1}. sorába lévő elemek összege {ossz}");
            }
        }
        static void Main(string[] args)
        {
            F01();
            F02();
            F03();
            Console.WriteLine("\n");
            F04();
        }
    }
}
