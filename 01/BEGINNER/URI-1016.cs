using System; 

class URI {

        public static void Main()
        {
            int d = int.Parse(Console.ReadLine());


            double t = (int) d / ((90 / 60.0) - (60 / 60.0));

            Console.WriteLine("{0} minutos", t);

            Console.ReadLine();
        }

}