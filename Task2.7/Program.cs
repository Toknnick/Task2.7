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
            string name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            int numberOfLine = 0;
            int centerLinesAndRows = 2;
            Console.SetCursorPosition(0, numberOfLine);

            for (int i = 0; i <= name.Length; i++)
            {
                if(i == name.Length)
                {
                    numberOfLine++;
                    Console.SetCursorPosition(0, numberOfLine );
                    i -= name.Length;
                }

                if(numberOfLine >= 3) 
                {
                    Console.SetCursorPosition(0, numberOfLine - centerLinesAndRows);
                    Console.Write(name);
                    Console.SetCursorPosition(0, numberOfLine);
                    break;
                }
                Console.Write(symbol);
            }
        }
    }
 }
