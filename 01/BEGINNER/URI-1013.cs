using System; 

class URI {

        static void Main(string[] args)
        {

            int a, b, c, tmp;

            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);

            tmp = a;
            if (a < b || a < c)
            {
                if (b < c)
                {
                    tmp = c;
                }
                else
                {
                    tmp = b;
                }
            }
            Console.WriteLine("{0} eh o maior", tmp);

            Console.ReadLine();

         }

}