using System; 

class URI {

        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            var a1 = Convert.ToDouble(s1[0]);
            var b1 = Convert.ToDouble(s1[1]);

            string[] s2 = Console.ReadLine().Split(' ');
            var a2 = Convert.ToDouble(s2[0]);
            var b2 = Convert.ToDouble(s2[1]);

            double p1 = a2 - a1;
            double p2 = b2 - b1;

            double distance = Math.Sqrt((p1 * p1) + (p2 * p2));

            Console.WriteLine(distance.ToString("0.0000"));

            Console.ReadLine();
         }

}