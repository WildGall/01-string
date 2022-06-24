using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_СтрокиСтолбцы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;
            int arrayHeight = 10;
            int[,] array = new int[arrayLength, arrayHeight];
            Random random = new Random();
            int maximumNumber = 10;
            int minimumNumber = 1;
            int sumNumberString = 0;
            int productNumberColumn = 1;         

            for (int i = 0; i < array.GetLength(0); i++)
            {                
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minimumNumber, maximumNumber);
                    Console.Write(array[i, j] + " ");
                }    
                Console.WriteLine();
            }
            Console.Write("Введите номер строки: ");
            int numberString = Convert.ToInt32(Console.ReadLine()) -1;
            Console.Write("Введите номер столбца: ");
            int numberColumn = Convert.ToInt32(Console.ReadLine()) -1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumNumberString += array[numberString, i];
            }

            for(int i = 0; i < array.GetLength(0); i++)
            {
                productNumberColumn *= array[i, numberColumn];
            }
            Console.WriteLine("Сумма значенией из строки " +  numberString + " равна: " + sumNumberString + "\nПроизведение значений из столбца " + numberColumn + " равно: " + productNumberColumn);
        }
    }
}
