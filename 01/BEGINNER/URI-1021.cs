using System; 

class URI {

        public static void Main()
        {
            double A, E;
            A = double.Parse(Console.ReadLine());
            int N, a, b, c, d, e, f, g, h, i, j, k, l, B, m, n, o, p, q, r, s, t, u;
            N = (int)A;
            a = N / 100;
            b = N % 100;
            c = b / 50;
            d = b % 50;
            e = d / 20;
            f = d % 20;
            g = f / 10;
            h = f % 10;
            i = h / 5;
            j = h % 5;
            k = j / 2;
            l = j % 2;

            E = A * 100;
            B = (int)E;
            m = B % 100;
            n = m / 50;
            o = m % 50;
            p = o / 25;
            q = o % 25;
            r = q / 10;
            s = q % 10;
            t = s / 5;
            u = s % 5;

            Console.Write("NOTAS:\n");
            Console.Write("{0} nota(s) de R$ 100.00\n", a);
            Console.Write("{0} nota(s) de R$ 50.00\n", c);
            Console.Write("{0} nota(s) de R$ 20.00\n", e);
            Console.Write("{0} nota(s) de R$ 10.00\n", g);
            Console.Write("{0} nota(s) de R$ 5.00\n", i);
            Console.Write("{0} nota(s) de R$ 2.00\n", k);
            Console.Write("MOEDAS:\n");
            Console.Write("{0} moeda(s) de R$ 1.00\n", l);
            Console.Write("{0} moeda(s) de R$ 0.50\n", n);
            Console.Write("{0} moeda(s) de R$ 0.25\n", p);
            Console.Write("{0} moeda(s) de R$ 0.10\n", r);
            Console.Write("{0} moeda(s) de R$ 0.05\n", t);
            Console.Write("{0} moeda(s) de R$ 0.01\n", u);

            Console.ReadLine();
        }

}