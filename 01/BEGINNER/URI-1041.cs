using System; 

class URI {

        public static void Main()
        {
            double a, b;
            string[] s = Console.ReadLine().Split(' ');
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);

            if (a == 0 && b == 0)
            {
                Console.Write("Origem\n");
            }
            else if (b == 0)
            {
                Console.Write("Eixo X\n");
            }

            else if (a == 0)
            {
                Console.Write("Eixo Y\n");
            }
            else if (a > 0 && b > 0)
            {
                Console.Write("Q1\n");
            }
            else if (a < 0 && b > 0)
            {
                Console.Write("Q2\n");
            }
            else if (a < 0 && b < 0)
            {
                Console.Write("Q3\n");
            }
            else
            {
                Console.Write("Q4\n");
            }
            Console.ReadLine();
        }

}