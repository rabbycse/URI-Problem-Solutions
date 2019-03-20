using System; 

class URI {

        public static void Main()
        {
            int n, max = -1, p = 0, i;
            for (i = 1; i < 101; ++i)
            {
                n = int.Parse(Console.ReadLine());
                if (max < n)
                {
                    max = n;
                    p = i;
                }
                               
            }

            Console.WriteLine("{0}\n{1}", max, p);

            Console.ReadLine();
        }

}