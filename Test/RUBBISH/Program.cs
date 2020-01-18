using System;

namespace RUBBISH
{
    class Program
    {        
        static void Main(string[] args)
        {
            foreach (string s in myReturn())
                Console.WriteLine(s);
            int[] mySortArray = { 4, 1, 2, 5, 3 };

            for (int i = 0; i <= 4; i++)
                mySortArray[i] = mySort(mySortArray, i);

            Console.WriteLine("\nОтсортированный массив:\n");
            foreach (int i in mySortArray)
                Console.Write("\t" + i);

            Console.ReadLine();
        }

        // Данный метод возвращает массив Info
        static Array myReturn()
        {
            string[] Info = { "Name", "Family", "Adress" };
            return Info;
        }

        // Передача массива в метод в качестве параметра
        // Данный метод возвращает значение одного из индексов
        // отсортированного массива
        static int mySort(Array sortArray, int i)
        {
            Array.Sort(sortArray);
            return (int)sortArray.GetValue(i);
        }
        
    }
}

