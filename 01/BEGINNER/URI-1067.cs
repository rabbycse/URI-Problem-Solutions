using System; 

class URI {

        public static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i = i+2)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }

}