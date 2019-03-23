using System; 

class URI {

        public static void Main()
        {
            float x, y, z, n;
            y = 0;
            z = 0;
            n = 0;
            while (true)
            {
                x = float.Parse(Console.ReadLine());
                if (n == 1)
                {

                    if (x == 2)
                    {
                        break;
                    }
                    else if (x == 1)
                    {
                        n = 0;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        continue;
                    }
                }
                else
                {
                    if (x < 0 || x > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else if (z == 0)
                    {
                        y = x;
                        z = 1;
                    }
                    else
                    {
                        Console.WriteLine("media = {0}", ((x + y) / 2.00).ToString("0.00"));
                        z = 0;
                        n = 1;
                    }
                }

                if (n == 1) Console.WriteLine("novo calculo (1-sim 2-nao)");

            }
            Console.ReadLine();
        }

}