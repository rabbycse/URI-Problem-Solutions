using System; 

class URI {

        public static void Main()
        {
            int M, N, sum = 0;
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                M = int.Parse(s[0]);
                N = int.Parse(s[1]);

                if (M <= 0 || N <= 0)
                    break;
                else
                {
                    sum = 0;
                    if (M < N)
                    {
                        for (int i = M; i <= N; i++)
                        {
                            Console.Write("{0} ", i);
                            sum += i;
                        }
                        Console.WriteLine("Sum={0}", sum);
                    }
                    else if (M > N)
                    {
                        for (int i = N; i <= M; i++)
                        {
                            Console.Write("{0} ", i);
                            sum += i;
                        }
                        Console.WriteLine("Sum={0}", sum);
                    }
                }
            }

            Console.ReadLine();
        }

}