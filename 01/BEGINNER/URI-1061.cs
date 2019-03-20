using System; 

class URI {

        public static void Main()
        {
            string a, b, c, d, e, f;
            int i, j, k, l, sec, min, p, q, r, s, hr, day, v; 
            int[] h = new int[5];

            string[] ar1 = Console.ReadLine().Split(' ');
            a = Convert.ToString(ar1[0]);
            i = Convert.ToInt32(ar1[1]);

            string[] ar2 = Console.ReadLine().Split(' ');
            j = Convert.ToInt32(ar2[0]);
            b = Convert.ToString(ar2[1]);
            k = Convert.ToInt32(ar2[2]);
            c = Convert.ToString(ar2[3]);
            l = Convert.ToInt32(ar2[4]);

            string[] ar3 = Console.ReadLine().Split(' ');
            f = Convert.ToString(ar3[0]);
            p = Convert.ToInt32(ar3[1]);

            string[] ar4 = Console.ReadLine().Split(' ');
            q = Convert.ToInt32(ar4[0]);
            d = Convert.ToString(ar4[1]);
            r = Convert.ToInt32(ar4[2]);
            e = Convert.ToString(ar4[3]);
            s = Convert.ToInt32(ar4[4]);

            sec = 60 - l + s;
            min = (60 - k - 1 + r) * 60;
            hr = (24 - 1 - j + q) * 3600;
            day = (p - i - 1) * 86400;
            v = sec + min + hr + day;

            h[0] = v / 86400;
            Console.WriteLine("{0} dia(s)", h[0]);

            h[0] = v % 86400;
            h[1] = h[0] / 3600;
            Console.WriteLine("{0} hora(s)", h[1]);

            h[1] = h[0] % 3600;
            h[2] = h[1] / 60;
            Console.WriteLine("{0} minuto(s)", h[2]);

            h[2] = h[1] % 60;
            Console.WriteLine("{0} segundo(s)", h[2]);

            Console.ReadLine();
        }

}