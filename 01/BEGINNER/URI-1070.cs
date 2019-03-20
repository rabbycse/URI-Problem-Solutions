using System; 

class URI {

        public static void Main()
        {
            int n, i;
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) n++;
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}", n);
                n = n + 2;
            }

            Console.ReadLine();
        }

}