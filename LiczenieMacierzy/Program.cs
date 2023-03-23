class Program
{
    static void Main(string[] args)
    {
        try 
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            Console.WriteLine("Podaj rozmiar pierwszej macierzy (zatwierdzajac klawiszem ENTER): ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj rozmiar drugiej macierzy (zatwierdzajac klawiszem ENTER): ");
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("M1[{0}][{1}], M2[{2}][{3}]", a, b, c, d);

            int[,] m1 = new int[a, b];
            int[,] m2 = new int[c, d];
            int[,] m1m2 = new int[a, b];

            Console.WriteLine("Macierz M1: {0} liczb, podaj je (zatwierdzajac klawiszem ENTER):", a * b);
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    m1[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("Macierz M2: {0} liczb, podaj je (zatwierdzajac klawiszem ENTER):", c * d);
            for (int i = 0; i < c; i++)
                for (int j = 0; j < d; j++)
                {
                    m2[i, j] = int.Parse(Console.ReadLine());
                }

            Console.Clear();
            Console.WriteLine("M1: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0} ", m1[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nM2: ");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("{0} ", m2[i, j]);
                }
                Console.WriteLine("");
            }

            #region Mnożenie macierzy
            Console.WriteLine("\nMnozenie macierzy:");
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < d; k++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        m1m2[i, k] += m1[i, j] * m2[j, k];
                    }
                }
            }

            Console.WriteLine("\nM1 x M2: ");
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < d; k++)
                {
                    Console.Write("{0} ", m1m2[i, k]);
                }
                Console.WriteLine("");
            }
            #endregion

            #region Dodawanie macierzy
            Console.WriteLine("\nDodanie macierzy: ");
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    m1m2[i, j] = m1[i, j] + m2[i, j];
                }

            Console.WriteLine("\nM1 + M2:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0} ", m1m2[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion

            #region Odejmowanie macierzy
            Console.WriteLine("\nOdejmowanie macierzy: ");
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    m1m2[i, j] = m1[i, j] - m2[i, j];
                }

            Console.WriteLine("\nM1 - M2:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0} ", m1m2[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}
