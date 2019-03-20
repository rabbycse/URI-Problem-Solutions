using System; 

class URI {

        public static void Main()
        {
            double a, b, c;
            string[] s = Console.ReadLine().Split(' ');
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.Write("Perimetro = {0}\n", (a + b + c).ToString("0.0"));
            }
            else
            {
                Console.Write("Area = {0}\n", (c * (a + b) / 2).ToString("0.0"));
            }

            Console.ReadLine();
        }

}