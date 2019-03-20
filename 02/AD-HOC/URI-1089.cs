using System; 

class URI {

         public static void Main()
        {
            int n = 0;
            int i = 0;
            int x = 0;

            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                x = 0;
                int[] array = new int[n];
                string[] s = Console.ReadLine().Split(' ');
                for (i = 0; i < n; i++)
                {
                    array[i] = Convert.ToInt32(s[i]);
                }

                for (i = 0; i < n; i++)
                {
                    if (array[i] < array[(i + 1) % n])
                    {
                        if (array[(i + 1) % n] > array[(i + 2) % n])
                        {
                            x++;
                        }

                    }

                    if (array[i] > array[(i + 1) % n])
                    {
                        if (array[(i + 1) % n] < array[(i + 2) % n])
                        {
                            x++;
                        }

                    }
                }
                Console.WriteLine("{0}", x);
                n = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }

}