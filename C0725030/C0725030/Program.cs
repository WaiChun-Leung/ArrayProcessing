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

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            printRepeating(arr, arr_size);

        }
        public static void printRepeating(int[] arr, int size)
        {
            int i, j;
            int counter = 0;
            Console.Write("Occurs 3 times the array elements are: ");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        Console.Write(arr[i] + " ");
                    }

                }
            }

            Program a = new Program();
            Console.WriteLine("The longest word is: ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }
        
        public string MyFunctionA(string input)
        {
            // Write a C# program to find the longest word in a string.
            string[] words = input.Split(' ');

            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;

            foreach(var word in words)
            {
                //TODO
                words[x++] = x;
            }

            // loop post condition: we now have array wordsLength which
            // contains the lengths of each word

            string currentWord = words[0];
            string nextWord;
            string longestWord = currentWord;


            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                //TODO: Use an IF Statement to make sure that variable longestWord
                //is always set to the Longest Word in the input string
                if (nextWord.CompareTo(currentWord) == 0)
                {
                    longestWord = nextWord;
                }
                else
                {
                    longestWord = currentWord;
                }
            }
            return longestWord;
        }
    }
}
