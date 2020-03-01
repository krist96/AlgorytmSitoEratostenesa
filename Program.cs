using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>(SitoEratostenesa(1, 500)); //wywołanie funkcji i przypisanie jej rezultatu.

            foreach(int a in numbers) 
            {
                Console.Write(a + ", "); //wypisanie wartości zwróconych z funkcji
            }

            Console.ReadKey();

        }
        public static List<int> SitoEratostenesa(int firstNumber, int lastNumber)
        {
            List<int> numbers = new List<int>();
            while (firstNumber < lastNumber)
            {
                if((firstNumber % 2 != 0) && (firstNumber % 3 != 0) && (firstNumber % 5 != 0) && (firstNumber != 1))
                {
                    numbers.Add(firstNumber);
                }
                firstNumber++;
            }
            return numbers;
            
        }
    }
}
