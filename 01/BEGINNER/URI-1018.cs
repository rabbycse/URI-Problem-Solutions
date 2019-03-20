using System; 

class URI {

        public static void Main()
        {
            int result;
            int n = int.Parse(Console.ReadLine()); 
            Console.WriteLine(n);
            Console.WriteLine("{0} nota(s) de R$ 100,00", n / 100);
            result = (n % 100);

            Console.WriteLine("{0} nota(s) de R$ 50,00", result / 50);
            result = (result % 50);

            Console.WriteLine("{0} nota(s) de R$ 20,00", result / 20);
            result = (result % 20);

            Console.WriteLine("{0} nota(s) de R$ 10,00", result / 10);
            result = (result % 10);

            Console.WriteLine("{0} nota(s) de R$ 5,00", result / 5);
            result = (result % 5);

            Console.WriteLine("{0} nota(s) de R$ 2,00", result / 2);
            result = (result % 2);

            Console.WriteLine("{0} nota(s) de R$ 1,00", result / 1);
            result = (result % 1);

            Console.ReadLine();
        }
}