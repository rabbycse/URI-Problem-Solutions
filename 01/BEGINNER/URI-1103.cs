using System; 

class URI {

        public static void Main()
        {
            int H1, H2, M1, M2;
            int hour, minute;  

            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                H1 = int.Parse(s[0]);
                H2 = int.Parse(s[1]);
                M1 = int.Parse(s[2]);
                M2 = int.Parse(s[3]);

                if (H1 == 0 && H2 == 0 && M1 == 0 && M2 == 0)
                {
                    break;
                }

                if (H1 == 0)
                {
                    hour = 24 * 60 + H2;
                }
                else
                {
                    hour = H1 * 60 + H2;
                }

                if (M1 == 0)
                {
                    minute = 24 * 60 + M2;
                }
                else
                {
                    minute = M1 * 60 + M2;
                }


                if (minute > hour)
                {
                    Console.WriteLine("{0}", minute - hour);
                }
                else
                {
                    Console.WriteLine("{0}", 24 * 60 - (hour - minute));
                }
                
            }

            Console.ReadLine();
        }

}