using System; 

class URI {

        public static void Main()
        {
           
            int tc, a, i;

            int Interval = 0;
            int outInterval = 0;

            tc = int.Parse(Console.ReadLine());

            for (i = 0; i < tc; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a >= 10 && a <= 20)
                {
                    Interval++; 
                }
                else
                {
                    outInterval++;
                }

            }
            Console.WriteLine("{0} in", Interval);
            Console.WriteLine("{0} out", outInterval);


            Console.ReadLine();
        }

}