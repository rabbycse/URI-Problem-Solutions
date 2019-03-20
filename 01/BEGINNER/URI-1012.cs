using System; 

class URI {

        static void Main(string[] args)
        {

            double a, b, c;

            string[] s = Console.ReadLine().Split(' ');
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
                
            Console.WriteLine("TRIANGULO: {0}", ((a * c) / 2).ToString("0.000"));
            Console.WriteLine("CIRCULO: {0}", (c * c * 3.14159).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: {0}", (((a + b) / 2) * c).ToString("0.000"));
            Console.WriteLine("QUADRADO: {0}", (b * b).ToString("0.000"));
            Console.WriteLine("RETANGULO: {0}", (a * b).ToString("0.000"));


            Console.ReadLine();

        }

}