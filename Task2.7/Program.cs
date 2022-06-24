using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Введите символ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            int stringInOrder = 0;
            int numberOfLines = 3;
            Console.SetCursorPosition(0, stringInOrder);
            string stringOfSymbols = "";

            for (int i = 0; i < name.Length; i++)
            {
                 stringOfSymbols += symbol;
            }

            for (int i = 0; i < numberOfLines; i++)
            {
                stringInOrder++;
                Console.WriteLine(stringOfSymbols);
            }

            Console.SetCursorPosition(0, 1);
            Console.Write(name);
        }
    }
 }
