using System;

namespace Test_8_PolesUP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int j = 0; ;j++)
            {
                double[] a = new double[3];
                Console.Write("(");
                for (int i = 0; i < 2; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition((i+1) * 4, j*2);
                    Console.Write(":");
                }
                a[2] = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition((3) * 4, j*2);
                Console.WriteLine(")");

                Console.Write("(");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write((long.Parse($"{Math.Round(a[i])}")).ToString("X"));
                    Console.SetCursorPosition((i + 1) * 3, j*2+1);
                    Console.Write(":");
                }
                Console.Write((long.Parse($"{Math.Round(a[2])}")).ToString("X"));
                Console.SetCursorPosition(3 * 3, j*2+1);
                Console.WriteLine(")");
                
            }
        }
    }
}
