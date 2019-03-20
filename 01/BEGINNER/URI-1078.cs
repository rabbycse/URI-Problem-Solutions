using System; 

class URI {

        public static void Main()
        {
            int n, i;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, n, i * n);
            }
            Console.ReadLine();
        }

}