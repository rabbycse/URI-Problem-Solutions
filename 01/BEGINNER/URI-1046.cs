using System; 

class URI {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            int result = b - a;

            if (result < 0)
            {
                result = 24 + (b - a);
            }
            if (a == b)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", result);
            }
                
            Console.ReadLine();
        }

}