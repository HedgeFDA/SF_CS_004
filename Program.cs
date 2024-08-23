using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_CS_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Array = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            var Result = 0;

            Console.Write("Текущий массив: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write((i > 0 ? ", " : "") + Array[i]);
            }

            foreach (var Item in Array)
            {
                Result += Item;
            }

            Console.WriteLine("\nСумма всех элементов массива: " + Result);
            Console.ReadKey();
        }
    }
}
