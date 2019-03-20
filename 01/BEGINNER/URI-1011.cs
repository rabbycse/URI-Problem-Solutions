using System; 

class URI {

        static void Main(string[] args)
        {

            int a;

            a = int.Parse(Console.ReadLine());
        
            Console.WriteLine("VOLUME = {0}", ((4 * 3.14159 * Math.Pow(a, 3)) / 3).ToString("0.000"));


            Console.ReadLine();

        }

}