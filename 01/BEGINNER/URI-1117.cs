using System; 

class URI {

        public static void Main()
        {
            double a, b, x = 0, y = 0; 
            while (true)
            {
                if (y == 2)
                    break;
                a = double.Parse(Console.ReadLine());
                if (a >= 0 && a <= 10)
                {
                    y++;
                    x += a;
                }
                else
                    Console.WriteLine("nota invalida");
            }
            b = x / 2.00;
            Console.WriteLine("media = {0}", b.ToString("0.00"));
            Console.ReadLine();
        }

}