using System; 

class URI {

        public static void Main()
        {
            int n, even = 0, odd = 0, positive = 0, negative = 0; 
            for (int i = 1; i <= 5; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) even++;
                if (n % 2 == 1 || n % 2 == -1) odd++;
                if (n > 0) positive++;
                if (n < 0) negative++;
            }
            Console.WriteLine("{0} valor(es) par(es)", even);
            Console.WriteLine("{0} valor(es) impar(es)", odd);
            Console.WriteLine("{0} valor(es) positivo(s)", positive);
            Console.WriteLine("{0} valor(es) negativo(s)", negative);

            Console.ReadLine();
        }

}