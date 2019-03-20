using System; 

class URI {

        public static void Main()
        {
            double a, p = 0;
            int i;
            for (i = 1; i <= 5; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (a%2 == 0)
                {
                    p += 1;
                }
            }
            Console.WriteLine("{0} valores pares", p);

            Console.ReadLine();
        }

}