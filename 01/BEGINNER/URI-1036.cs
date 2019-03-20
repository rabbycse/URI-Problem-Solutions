using System; 

class URI {

        public static void Main()
        {
            double a, b, c, r1, r2, del;

            string[] s = Console.ReadLine().Split(' ');
            a = Convert.ToDouble(s[0]);
            b = Convert.ToDouble(s[1]);
            c = Convert.ToDouble(s[2]);

            del = (b * b) - (4 * a * c);

            r1 = (-b + Math.Sqrt(del)) / (2 * a);

            r2 = (-b - Math.Sqrt(del)) / (2 * a);

            if (a != 0 && del > 0)

            {

                Console.Write("R1 = {0}\nR2 = {1}\n", r1.ToString("0.00000"), r2.ToString("0.00000"));

            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

            Console.ReadLine();

        }

}