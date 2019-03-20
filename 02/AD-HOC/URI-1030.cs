using System; 

class URI {

        public static int josephusLoop(int n, int k, int startingPoint)
        {
            if (n == 1)
                return 1;

            int newSp, survivor;
            newSp = (startingPoint + k - 2) % n + 1;
            survivor = josephusLoop(n - 1, k, newSp);

            if (survivor < newSp)
            {
                return survivor;
            }
            else
            {
                return survivor + 1;
            }
        }

        public static int josephus(int n, int k)
        {
            return josephusLoop(n, k, 1);
        }

        public static void Main()
        {
            int tc, n, k, s, i;
            tc = int.Parse(Console.ReadLine());

            for (i = 1; i <= tc; ++i)
            {
                string[] ar = Console.ReadLine().Split(' ');
                n = int.Parse(ar[0]);
                k = int.Parse(ar[1]);
                s = josephus(n, k);
                Console.WriteLine("Case {0}: {1}", i, s);
            }

            Console.ReadLine();
        }

}