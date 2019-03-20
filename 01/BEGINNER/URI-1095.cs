using System; 

class URI {

        public static void Main()
        {
            int i, j;

            for (j = 60, i=1; j>=0; j -= 5, i += 3)
            {
                Console.Write("I={0}", i);
                Console.WriteLine(" J={0}", j);
            }

            Console.ReadLine();
        }

}