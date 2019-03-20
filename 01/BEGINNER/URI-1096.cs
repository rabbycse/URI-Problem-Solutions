using System; 

class URI {

        public static void Main()
        {
            int i, j;

            for (i = 1; i < 10; i += 2)
            {
                for(j = 7; j >= 5; j--)
                {
                    Console.Write("I={0}", i);
                    Console.WriteLine(" J={0}", j);
                }
                
            }

            Console.ReadLine();
        }

}