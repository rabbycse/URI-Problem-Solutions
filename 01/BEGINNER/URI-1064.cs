using System; 

class URI {

        public static void Main()
        {
            double a, b = 0, avg;
            int i, postive = 0;
            for (i = 1; i <= 6; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    postive++;
                    b += a;
                }
            }
            avg = b / postive;
            Console.WriteLine("{0} valores positivos", postive);
            Console.WriteLine("{0}", avg.ToString("0.0"));

            Console.ReadLine();
        }

}