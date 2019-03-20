using System; 

class URI {

        public static void Main()
        {
            int a, b;
            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.Write("Sao Multiplos\n");
            }
            else
            {
                Console.Write("Nao sao Multiplos\n");
            }

            Console.ReadLine();
        }

}