using System; 

class URI {

        public static void Main()
        {
            int a, b, c, d, x, y;
            string[] s = Console.ReadLine().Split(' ');
             a = int.Parse(s[0]);
             x = int.Parse(s[1]);
             b = int.Parse(s[2]);
             y = int.Parse(s[3]);

            if (a == y && b == y && y == x)
            {
                c = x - y;
                d = 24 + a - b;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (a == b && y > x)
            {
                c = y - x;
                d = a - b;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (a == b && x > y)
            {
                c = 60 - x + y;
                d = 24 - a + b - 1;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (x == y && a < b)
            {
                c = 0;
                d = b - a;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (x == y && a > b)
            {
                c = 0;
                d = 24 - a + b;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (b > a && y > x)
            {
                c = y - x;
                d = b - a;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (a < b && x > y)
            {
                c = 60 - x + y;
                d = b - a - 1;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (a > b && x < y)
            {
                c = y - x;
                d = 24 - a - 1 + b;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }
            else if (a > b && x > y)
            {
                c = 60 + y - x;
                d = 24 + b - a - 1;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", d, c);
            }

            Console.ReadLine();
        }

}