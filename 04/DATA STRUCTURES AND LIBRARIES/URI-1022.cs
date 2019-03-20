using System; 

class URI {

        public static void Main()
        {
            char c1, c2, c3;
            int N1, N2, D1, D2, num, den, numS, denS, e;

            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; ++i)
            {
                string[] s = Console.ReadLine().Split(' ');
                N1 = int.Parse(s[0]);
                c1 = char.Parse(s[1]);
                D1 = int.Parse(s[2]);
                c2 = char.Parse(s[3]);
                N2 = int.Parse(s[4]);
                c3 = char.Parse(s[5]);
                D2 = int.Parse(s[6]);
              
                if (c2 == '+')
                {
                    num = ((N1 * D2) + (N2 * D1));
                    den = (D1 * D2);
                }
                else if (c2 == '-')
                {
                    num = ((N1 * D2) - (N2 * D1));
                    den = (D1 * D2);
                }
                else if (c2 == '*')
                {
                    num = (N1 * N2);
                    den = (D1 * D2);
                }
                else
                {
                    num = (N1 * D2);
                    den = (N2 * D1);
                }

                e = euclides(num, den);
                numS = num / e;
                denS = den / e;

                if (numS > 0 && denS > 0)
                {
                    Console.WriteLine("{0}/{1} = {2}/{3}", num, den, numS, denS);
                }
                else
                {
                    if (denS < 0)
                    {
                        denS = -denS;
                        numS = -numS;
                    }
                    Console.WriteLine("{0}/{1} = {2}/{3}", num, den, numS, denS);
               
                }
            }
            Console.ReadLine();
        }

        public static int euclides(int a, int b)
        {
            int divisor, dividendo, c;

            if (a == 0)
                return 1;

            if (b > a)
            {
                dividendo = b;
                divisor = a;
            }
            else
            {
                dividendo = a;
                divisor = b;
            }

            while (dividendo % divisor != 0)
            {
                c = dividendo % divisor;
                dividendo = divisor;
                divisor = c;
            }
            return divisor;
        }

}