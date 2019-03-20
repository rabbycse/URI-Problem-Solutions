using System; 

class URI {

        public static void Main()
        {
            int x, y, n, tmp, sum = 0, i;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                tmp = y;
                y = x;
                x = tmp;
            }
            if(x%2 == 0)
            {
                x++;
                n = x;
            }
            else
            {
                n = x + 2;
            }

            for(i=n; i<y; i += 2)
            {
                sum += i;
            }

            Console.WriteLine("{0}", sum);

            Console.ReadLine();
        }

}