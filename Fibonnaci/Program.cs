using System;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int eerste = 0;
            int tweede = 1;
            int derde;

            int aantal = 20;

            Console.Write($"{eerste},{tweede}");

            for (int i = 0; i < aantal; i++)
            {
                Console.Write(",");
                derde = eerste + tweede;
                Console.Write(derde);

                eerste = tweede;
                tweede = derde;
            }
            Console.ReadLine();
        }
    }
}
