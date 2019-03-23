using System; 

class URI {

        public static void Main()
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                    Console.WriteLine("Senha Invalida");
            }
            Console.ReadLine();
        }

}