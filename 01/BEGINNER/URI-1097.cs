using System; 

class URI {

    public static void Main()
    {
         int i, j, k = 7, l;
         for (i = 1; i <= 9; i += 2)
         {
              for (l = 1, j = k; l <= 3; j--, l++)
              {
                   Console.Write("I={0} ", i);
                   Console.WriteLine("J={0}", j);
              }

         k += 2;
       }

       Console.ReadLine();
    }
}