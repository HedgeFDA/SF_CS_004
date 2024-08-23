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
            //var Array = new int[] { 1, 2, 3, 4, 5, 6, 7 }; 
            var Array = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            bool ArrayIsSorted = true;

            Console.Write("Текущий массив: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write((i > 0 ? ", " : "") + Array[i]);

                if (i > 0 && Array[i] < Array[i - 1])
                {
                    ArrayIsSorted = false;
                }
            }

            Console.Write("\n" + (ArrayIsSorted ? "Массив отсортирован." : "Массив не отсортирован.") + "\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine("");

            var Step = 0;
            while (!ArrayIsSorted)
            {
                if (Step == 0)
                {
                    Console.WriteLine("\nВыполняем сортировку...");
                }
                else
                {
                    Console.Write("Промежуточный результат: ");
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.Write((i > 0 ? ", " : "") + Array[i]);
                    }
                    Console.Write("\n");
                }

                ArrayIsSorted = true;

                for (int i = 0; i < (Array.Length - 1); i++)
                {
                    if (Array[i] <= Array[i + 1])
                    {
                        continue;
                    }

                    Step++;
                    Console.WriteLine("{0}) Меняем местами {1} и {2}, (с позиции {3} на позицию {4})",
                      Step, Array[i], Array[i + 1], (i + 1), (i + 2));

                    Array[i] += Array[i + 1];
                    Array[i + 1] = Array[i] - Array[i + 1];
                    Array[i] -= Array[i + 1];

                    if (i > 0 && Array[i] < Array[i - 1])
                    {
                        ArrayIsSorted = false;
                    }
                }
            }

            Console.Write("\nОтсортировнный массив: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write((i > 0 ? ", " : "") + Array[i]);
            }
            Console.Write("\nДля завершения нажмите любую клавишу...");

            Console.ReadKey();
        }
    }
}
