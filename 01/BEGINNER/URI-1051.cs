using System; 

class URI {

        public static void Main()
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            if (a >= 0 && a <= 2000)
                Console.WriteLine("Isento");
            else if (a >= 2000.01 && a <= 3000)
            {
                a -= 2000;
                b = a * .08;
                Console.WriteLine("R$ {0}", b.ToString("0.00"));
            }
            else if (a >= 3000.01 && a <= 4500)
            {
                a -= 3000;
                b = a * .18 + 80;
                Console.WriteLine("R$ {0}", b.ToString("0.00"));
            }
            else
            {
                a -= 4500;
                b = a * .28 + 350;
                Console.WriteLine("R$ {0}", b.ToString("0.00"));
            }

            Console.ReadLine();
        }

}