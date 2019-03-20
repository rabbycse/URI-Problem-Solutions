using System; 

class URI {

        public static void Main()
        {
            int n, counter, tmp;
            string s;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                s = Console.ReadLine();
              
                counter = 0;
                tmp = 0;

                for (int j = 0; j < s.Length; ++j)
                {
                    if (s[j] == '<')
                        tmp++;
                    if (s[j] == '>' && tmp > 0)
                    {
                        counter++;
                        tmp--;
                    }
                }

                Console.WriteLine(counter);
            }

            Console.ReadLine();
        }

}