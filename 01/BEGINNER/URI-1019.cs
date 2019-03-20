using System; 

class URI {

        public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            int h = t / 3600;
            t = t - (h * 3600);

            int m = t / 60;
            t = t - (m * 60);

            Console.WriteLine("{0}:{1}:{2}",h, m, t);

            Console.ReadLine();
        }

}