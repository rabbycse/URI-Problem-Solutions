using System; 

class URI {

        public static int remaining(int n, int k)
        {
            int r = 0;
            for (int i = 1; i < n; i++)
                r = (r + k) % i;

            return r;
        }

        public static void Main()
        {
            int n, y;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                y = 1;
                for (; ; )
                {
                    if (remaining(n, y) != 11) y++;
                    else break;
                }
                Console.WriteLine(y);
            }

            Console.ReadLine();
        }

}