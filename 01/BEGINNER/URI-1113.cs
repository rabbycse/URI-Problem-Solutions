using System; 

class URI {

        public static void Main()
        {
            int X, Y;
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                X = int.Parse(s[0]);
                Y = int.Parse(s[1]);
                if (X == Y)
                    break;
                else
                {
                    if (X < Y)
                        Console.WriteLine("Crescente");
                    else
                        Console.WriteLine("Decrescente");
                }
            }

            Console.ReadLine();
        }

}