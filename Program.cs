namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static int[,] negyzetesMatrix = new int[10, 10];
        static Random r = new Random();
        static void F01(int[,]matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // sorokon megy végig
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max+1);
                }
            }
        }
        static void F02(int[,]matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)//sor
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//oszlop
                {
                    Console.Write($"{matrix[i,j],5}");// 5 karaternyi helyet hagya számoknak
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
        static void F05()
        {
            for (int j = 0; j < oszlopokSzama; j++)
            {
                int ossz = 0;
                for (int i = 0; i < sorokSzama; i++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"A mátrix {j + 1}. oszlopába lévő elemek összege {ossz}");
            }
        }
        static void Main(string[] args)
        {
            F01(szamokMatrix, 10, 99);
            F02(szamokMatrix);
            F03();
            Console.WriteLine("\n");
            F04();
            Console.WriteLine("\n");
            F05();
            F01(negyzetesMatrix, -100, 100);
            F02(negyzetesMatrix);
        }
    }
}
