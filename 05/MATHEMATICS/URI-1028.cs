using System; 

class URI {

        public static int mdc(int x, int y)
        {
            int s = 0;
            while (y % x != 0)
            {
                s = x;
                x = y % x;
                y = s;
            }
            return x;
        }

        public static void Main()
        {
            int n, x, y, aux;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);

                if (x > y)
                {
                    aux = x;
                    x = y;
                    y = aux;
                }

                Console.WriteLine(mdc(x, y));
            }

            Console.ReadLine();
        }

}