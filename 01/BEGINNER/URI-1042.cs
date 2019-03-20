using System; 

class URI {

        public static void Main()
        {
            int A, B, C;
            string[] s = Console.ReadLine().Split(' ');
            A = int.Parse(s[0]);
            B = int.Parse(s[1]);
            C = int.Parse(s[2]);

            if (A < B && A < C)
            {
                if (B < C)
                    Console.Write("{0}\n{1}\n{2}\n", A, B, C);
                else Console.Write("{0}\n{1}\n{2}\n", A, C, B);
            }
            if (B < A && B < C)
            {
                if (A < C)
                    Console.Write("{0}\n{1}\n{2}\n", B, A, C);
                else Console.Write("{0}\n{1}\n{2}\n", B, C, A);
            }
            if (C < B && C < A)
            {
                if (B < A)
                    Console.Write("{0}\n{1}\n{2}\n", C, B, A);
                else Console.Write("{0}\n{1}\n{2}\n", C, A, B);
            }
            Console.Write("\n{0}\n{1}\n{2}\n", A, B, C);

            Console.ReadLine();

        }

}