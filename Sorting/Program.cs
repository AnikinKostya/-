using System;

namespace Sorting
{
    class Sort
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[10];
            Console.WriteLine("Введите любые 10 чисел: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}-е: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }



            
            int sort;

             for (int i = 0; i < arr.Length - 1; i++)
             {
                 for (int j = i + 1; j < arr.Length; j++)
                 {
                     if (arr[i] > arr[j])
                     {
                         sort = arr[i];
                         arr[i] = arr[j];
                         arr[j] = sort;
                     }
                 }
             }

             
             Console.WriteLine("Вывод отсортированного массива");

             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i]);
             }
             Console.ReadLine();
        }
    }
}
