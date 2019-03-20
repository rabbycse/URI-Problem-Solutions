using System; 

class URI {

        public static void Main()
        {
            int X, Y;
            float price = 0;

            string[] s = Console.ReadLine().Split(' ');
            X = int.Parse(s[0]);
            Y = int.Parse(s[1]);
            if (X == 1)
            {
                price = (float)(4.00 * Y);
            }
            else if (X == 2)
            {
                price = (float)(4.50 * Y);
            }
            else if (X == 3)
            {
                price = (float)(5.00 * Y);
            }
            else if (X == 4)
            {
                price = (float)(2.00 * Y);
            }
            else if (X == 5)
            {
                price = (float)(1.50 * Y);
            }

            Console.WriteLine("Total: R$ {0}", price.ToString("0.00"));

            Console.ReadLine();
        }

}