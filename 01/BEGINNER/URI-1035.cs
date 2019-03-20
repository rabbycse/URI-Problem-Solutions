using System; 

class URI {

        public static void Main()
        {
            int a, b, c, d;
            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);
            d = int.Parse(s[3]);

            if ((b > c) && (d > a) && (c + d > a + b) && c > 0 && c > 0 && (a % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.ReadLine();
        }

}