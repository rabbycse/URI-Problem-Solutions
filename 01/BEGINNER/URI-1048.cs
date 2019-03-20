using System; 

class URI {

        public static void Main()
        {
            float n;
            n = float.Parse(Console.ReadLine());
            if (n <= 400.0)
                Console.Write("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: 15 %\n", (n * 1.15).ToString("0.00"), (n * 0.15).ToString("0.00"));
            else if (n <= 800.0)
                Console.Write("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: 12 %\n", (n * 1.12).ToString("0.00"), (n * 0.12).ToString("0.00"));
            else if (n <= 1200.0)
                Console.Write("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: 10 %\n", (n * 1.10).ToString("0.00"), (n * 0.10).ToString("0.00"));
            else if (n <= 2000.0)
                Console.Write("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: 7 %\n", (n * 1.07).ToString("0.00"), (n * 0.07).ToString("0.00"));
            else
                Console.Write("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: 4 %\n", (n * 1.04).ToString("0.00"), (n * 0.04).ToString("0.00"));

            Console.ReadLine();
        }

}