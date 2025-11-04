using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2DArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] alphabet = new char[26, 2];

            int row = alphabet.GetLength(0);
            int col = alphabet.GetLength(1);
            Console.WriteLine(row);
            Console.WriteLine(col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == 0)
                    {
                        alphabet[i, j] = (char)(65 + i);
                    } 
                    else
                    {
                        alphabet[i, j] = (char)(97 + i);
                    }
                }
            }

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(alphabet[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
