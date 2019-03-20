using System; 

class URI {

        public static void Main()
        {
            double n;

            n = Convert.ToDouble(Console.ReadLine());

            if (n < 0 || n > 100)

            {

                Console.WriteLine("Fora de intervalo");

            }

            else if (n <= 25.00)

            {

                Console.WriteLine("Intervalo [0,25]");

            }

            else if (n <= 50.0)

            {

                Console.WriteLine("Intervalo (25,50]");

            }

            else if (n <= 75.0)

            {

                Console.WriteLine("Intervalo (50,75]");

            }

            else if (n <= 100.0)

            {

                Console.WriteLine("Intervalo (75,100]");

            }

            Console.ReadLine();
        }

}