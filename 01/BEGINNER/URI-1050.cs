using System; 

class URI {

        public static void Main()
        {
            int N;
            N = int.Parse(Console.ReadLine());
            if (N == 61)
                Console.WriteLine("Brasilia");
            else if (N == 71)
                Console.WriteLine("Salvador");
            else if (N == 11)
                Console.WriteLine("Sao Paulo");
            else if (N == 21)
                Console.WriteLine("Rio de Janeiro");
            else if (N == 32)
                Console.WriteLine("Juiz de Fora");
            else if (N == 19)
                Console.WriteLine("Campinas");
            else if (N == 27)
                Console.WriteLine("Vitoria");
            else if (N == 31)
                Console.WriteLine("Bela Horizonte");
            else
                Console.WriteLine("DDD nao cadastrado");

            Console.ReadLine();
        }

}