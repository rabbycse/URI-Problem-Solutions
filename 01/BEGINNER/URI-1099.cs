using System; 

class URI {

        public static void Main()
        {
            int tc, X, Y, k, count = 0;
            tc = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tc; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                X = int.Parse(s[0]);
                Y = int.Parse(s[1]);
            
                if (X == Y)
                {
                    count = 0;
                    Console.WriteLine("{0}", count);
                }
                else if (X < Y)
                {
                    for (k = X + 1, count = 0; k < Y; k++)
                    {
                        if (k % 2 == 1 || k % 2 == -1)
                            count += k;
                    }
                    Console.WriteLine("{0}", count);
                }
                else
                {
                    for (k = Y + 1, count = 0; k < X; k++)
                    {
                        if (k % 2 == 1 || k % 2 == -1)
                            count += k;
                    }
                    Console.WriteLine("{0}", count);
                }
            }

            Console.ReadLine();
        }
}