using System; 

class URI {

        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());


            Console.WriteLine("{0} km/l", (a / b).ToString("0.000"));

            Console.ReadLine();

          }

}