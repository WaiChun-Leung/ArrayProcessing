using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 17, 11, 9, 3, 4, 11, 6, 11, 8, 7 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);

        }
        public static void printRepeating(int[] arr, int size)
        {
            int i, j;
            int counter = 0;
            Console.WriteLine("Occurs 3 times the array elements are: ");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        Console.WriteLine(arr[i]);
                    }
                        
                }
            }
            
        }
    }
}
