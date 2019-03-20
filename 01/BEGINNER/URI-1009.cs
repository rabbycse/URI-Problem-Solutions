using System; 

class URI {

    static void Main(string[] args)
        {

            double a;
            double b;
            string word;

            word = Console.ReadLine();
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("TOTAL = R$ {0}", (a + ((b / 100) * 15)).ToString("0.00"));


            Console.ReadLine();

        }

}