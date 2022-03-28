using System;

namespace ConsoleApp2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "123";
            string userInput;

            for(int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.WriteLine("Тайное сообщение");
                    break;
                }
                else
                {
                    Console.WriteLine("Осталось " + (tryCount - i - 1) + " попыток");
                }
            }            
        }
    }
}
