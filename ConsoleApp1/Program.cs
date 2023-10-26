class Zad
{
    static void Main(string[] args)
    {
        int N;
        Console.WriteLine("Podaj liczbę wierszy: ");
        N = int.Parse(Console.ReadLine());
        //a
        /*
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        */
        //b
        /*
         for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N-i+1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
         */
        //c
        /*
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N - i + 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }    
            Console.WriteLine();
        }
        */
        //d
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
            {
                if (i==1 || i==N || j==1|| j==N)
                {
                    Console.Write("*");
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}