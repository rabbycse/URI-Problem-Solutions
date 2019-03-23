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

                if (X == 0 || Y == 0)
                    break;
                else if (X > 0 && Y > 0)
                    Console.WriteLine("primeiro");
                else if (X > 0 && Y < 0)
                    Console.WriteLine("quarto");
                else if (X < 0 && Y < 0)
                    Console.WriteLine("terceiro");
                else if (X < 0 && Y > 0)
                    Console.WriteLine("segundo");
            }
            Console.ReadLine();
        }

}