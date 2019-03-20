using System; 

class URI {

        public static void Main()
        {
            int tc, n, a = 0, b = 0, c = 0, total;
            double x, y, z;
            string str;
       
            tc = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tc; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                n = Convert.ToInt32(s[0]);
                str = Convert.ToString(s[1]);

                if (str[0] == 'C') a += n;
                else if (str[0] == 'R') b += n;
                else if (str[0] == 'S') c += n;
            }
            total = a + b + c;

            x = (a / (total * 1.0)) * 100.00;
            y = (b / (total * 1.0)) * 100.00;
            z = (c / (total * 1.0)) * 100.00;

            Console.WriteLine("Total: {0} cobaias", total);

            Console.WriteLine("Total de coelhos: {0}", a);
            Console.WriteLine("Total de ratos: {0}", b);
            Console.WriteLine("Total de sapos: {0}", c);

            Console.WriteLine("Percentual de coelhos: {0} %", x.ToString("0.00"));
            Console.WriteLine("Percentual de ratos: {0} %", y.ToString("0.00"));
            Console.WriteLine("Percentual de sapos: {0} %", z.ToString("0.00"));

            Console.ReadLine();
        }

}