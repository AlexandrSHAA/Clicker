using System;


namespace temporary
{
    class Program
    {
        int b = 1;
        static void Main(string[] args)
        {
            int b = 5;
           
            for (int i = 0; i < 10; i++)
            {
                b = 9;
                Console.WriteLine(b);
            }
            Console.WriteLine("снаружи" + b);
        }
      //  Console.WriteLine(b);
    }
}
