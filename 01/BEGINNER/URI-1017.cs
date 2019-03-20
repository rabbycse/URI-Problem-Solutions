using System; 

class URI {

        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());


            double r = (a * b) / 12;

            Console.WriteLine(r.ToString("0.000"));

            Console.ReadLine();
        }

}