using System;

namespace Task2
{
    class Program2
    {
        //Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello, Please input name (Ru) ");
                var data = Console.ReadLine();
                if (data.Length != 0)
                {
                    var result = CheckStringForResult(data);
                    Console.WriteLine(result);
                    Console.WriteLine("(Empty string for exit)");
                }
                else break;
            }
        }

        public static string CheckStringForResult(string data)
        {
            if (data == "Вячеслав") return $"Привет, {data}";
            else return "Нет такого имени";
        }
    }
}
