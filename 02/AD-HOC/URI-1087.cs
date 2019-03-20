using System; 

class URI {

        public static void Main()
        {
            int x1, y1, x2, y2;

            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                x1 = int.Parse(s[0]);
                y1 = int.Parse(s[1]);
                x2 = int.Parse(s[2]);
                y2 = int.Parse(s[3]);

                if (x1 == 0 && y1 == 0 && x2 == 0 && y2 == 0)
                {
                    break;
                }

                if (x1 == x2 && y1 == y2)
                {
                    Console.WriteLine("0");
                }

                else if ((x2 - x1) == -(y2 - y1) || -(x2 - x1) == -(y2 - y1) || -(x2 - x1) == (y2 - y1) || (x2 - x1) == (y2 - y1))
                {
                    Console.WriteLine("1");
                }
                else if (x1 == x2 || y1 == y2)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("2");
                }
                
            }

            Console.ReadLine();
        }

}