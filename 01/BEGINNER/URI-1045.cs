using System; 

class URI {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a * a == (b * b + c * c) || b * b == (a * a + c * c) || c * c == (a * a + b * b))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a * a > (b * b + c * c) || b * b > (a * a + c * c) || c * c > (a * a + b * b))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a * a < (b * b + c * c) || b * b < (a * a + c * c) || c * c < (a * a + b * b))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && a == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
}