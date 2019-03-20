using System; 

class URI {

        public static void Main()
        {

            int n, i;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}^2 = {1}", i, (i * i));
                }
            }


            Console.ReadLine();
        }

}