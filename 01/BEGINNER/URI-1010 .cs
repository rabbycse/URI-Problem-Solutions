using System; 

class URI {

        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            double c = double.Parse(s[2]);

            double res = b * c;

            string[] s2 = Console.ReadLine().Split(' ');
            int a1 = int.Parse(s2[0]);
            int b1 = int.Parse(s2[1]);
            double c1 = double.Parse(s2[2]);

            double result = res + b1 * c1;

            Console.WriteLine("VALOR A PAGAR: R$ " + result.ToString("0.00"));
            Console.ReadLine();

         }

}