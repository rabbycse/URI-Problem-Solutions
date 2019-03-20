using System; 

class URI {

        public static void Main()
        {
            int k, n, m, x, y, i;

            while (true)
            {
                k = int.Parse(Console.ReadLine());
                if (k == 0) break;

                string[] s1 = Console.ReadLine().Split(' ');
                n = int.Parse(s1[0]);
                m = int.Parse(s1[1]);

                for (i = 0; i < k; i++)
                {
                    string[] s2 = Console.ReadLine().Split(' ');
                    x = int.Parse(s2[0]);
                    y = int.Parse(s2[1]);
                    if (x == n || y == m) Console.WriteLine("divisa");
                    else if (x > n && y > m) Console.WriteLine("NE");
                    else if (x > n && y < m) Console.WriteLine("SE");
                    else if (x < n && y > m) Console.WriteLine("NO");
                    else if (x < n && y < m) Console.WriteLine("SO");
                }
            }
            Console.ReadLine();
        }

}