using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);
                Console.WriteLine(alphabet[i]);
            }
            Console.WriteLine();

            for (int i = alphabet.Length; --i >= 0;)
            {
                Console.WriteLine(alphabet[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = Char.ToUpper(alphabet[i]);
                Console.WriteLine(alphabet[i]);
            }
            Console.WriteLine();


            int[] fibonacci = { 12, 1, 2, 3, 5, 8, 1, 34, 21, 55 };
            int max = 0;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (fibonacci[i] > max)
                { 
                    max = fibonacci[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine();

            Array.Sort(fibonacci);
            foreach (int i in fibonacci)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int toFind = 34;
            int index = 0;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (fibonacci[i] == toFind)
                {
                    index = i; 
                    break;
                }
            }
            Console.WriteLine(index);


        }
    }
}
