using System; 

class URI {

        public static void Main()
        {
            int T, X, Y;
            double div;
            T = int.Parse(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                X = int.Parse(s[0]);
                Y = int.Parse(s[1]);

                if (Y == 0)
                    Console.WriteLine("divisao impossivel");
                else
                {
                    div = X / (Y * 1.00);
                    Console.WriteLine("{0}", div.ToString("0.0"));
                }
            }
            Console.ReadLine();
        }

}