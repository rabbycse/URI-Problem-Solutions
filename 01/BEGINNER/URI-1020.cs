using System; 

class URI {

        public static void Main()
        {
            int n;

            n = int.Parse(Console.ReadLine());

            int a = n / 365;
            int rA = n % 365;
            int rM = rA % 30;
            int m = rA / 30;
            int d = rM % 30;

            Console.Write("{0} ano(s)\n{1} mes(es)\n{2} dia(s)\n", a, m, d);

            Console.ReadLine();
        }

}