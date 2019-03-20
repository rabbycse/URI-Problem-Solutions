using System; 

class URI {

    static void Main(string[] args) 
    {
            int a, b, c, d, difference;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            difference = ((a * b) - (c * d));

            Console.WriteLine("DIFERENCA = " + difference);
            Console.ReadKey();
    }

}