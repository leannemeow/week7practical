using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> months = new List<string>();

            months.Add("Jan");
            months.Add("Feb");
            months.Add("Mar");
            months.Add("Apr");
            months.Add("May");
            months.Add("Jun");
            months.Add("Jul");
            months.Add("Aug");
            months.Add("Sep");
            months.Add("Oct");
            months.Add("Nov");
            months.Add("Dec");

            string[] monthsName = months.ToArray();

            for (int i = 0; i < monthsName.Length; i++)
            {
                Console.WriteLine(monthsName[i]);
            }
            Console.WriteLine();

            int befLeng = months.Count;
            Console.WriteLine(befLeng);
            Console.WriteLine();

            months.Remove("Sep");
            months.Remove("Nov");

            int aftLeng = months.Count;
            Console.WriteLine(aftLeng);
            Console.WriteLine();

            string findMonth = "Dec";
            int index = months.IndexOf(findMonth);
            Console.WriteLine(index);
        }
    }
}
