using System;

namespace Task1
{
    class Program1
    {
        //Составить алгоритм: если введенное число больше 7, то вывести “Привет”

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello, Please input number ");
                var data = Console.ReadLine();
                if (data.Length != 0)
                {
                    var intValue = Convert.ToInt32(data);
                    var result = CheckNumberForStringResult(intValue);
                    Console.WriteLine(result);
                    Console.WriteLine("Empty number for exit");
                }
                else break;
            }
        }

        public static string CheckNumberForStringResult(int number)
        {
            if (number > 7) return "Привет";
            else return "Число меньше либо равно 7";
        }
    }
}
