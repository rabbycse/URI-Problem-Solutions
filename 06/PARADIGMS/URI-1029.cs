using System; 

class URI {

        public static int m;
        public static int fib(int n)
        {
            m++;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }

        public static void Main()
        {
            int tc, x, res;
            tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                m = 0;
                x = int.Parse(Console.ReadLine());
                res = fib(x);
          
                Console.WriteLine("fib({0}) = {1} calls = {2}", x, (m - 1), res);
            }

            Console.ReadLine();
        }

}