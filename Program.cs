using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "one1";
            string userInput;
            int countTry = 3;

            for (int i = 0; i < countTry; i++)
            {
                Console.Write("Введите пароль : ");
                userInput = Console.ReadLine();

                if(userInput == password)
                {
                    Console.WriteLine("Вы ввели правильный пароль, позравляю вас");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы ввели неверный пароль, у вас осталось {countTry - (i + 1)} попыток");
                }
            }            
        }
    }
}
