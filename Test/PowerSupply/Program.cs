using System;

namespace RUBBUSH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            Addition(array);

            Addition();
            Console.ReadLine();
        }        

        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i=0;i<integers.Length;i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
    }
}
