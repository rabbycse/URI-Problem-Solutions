using System; 

class URI {

         public static void Main()
        {

            int n, i;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10000; ++i)
            {
                if (i % n == 2)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }

}