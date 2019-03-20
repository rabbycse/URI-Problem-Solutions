using System; 

class URI {

        public static void Main()
        {
            int tc;
            double a;
            double b;
            double c;

            tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; ++i)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = double.Parse(s[0]);
                b = double.Parse(s[1]);
                c = double.Parse(s[2]);

                double med = ((a / 10) * 2) + ((b / 10) * 3) + ((c / 10) * 5);

                Console.WriteLine("{0}", med.ToString("0.0"));
            }
            Console.ReadLine();
        }

}