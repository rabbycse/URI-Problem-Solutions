using System; 

class URI {

        public static void Main()
        {
            double a, b, c = 0;
            for (a = 1; a <= 6; a++)
            {
                b = double.Parse(Console.ReadLine());
                if (b > 0) c++;
            }
            Console.WriteLine("{0} valores positivos", c.ToString("0."));

            Console.ReadLine();
        }

}