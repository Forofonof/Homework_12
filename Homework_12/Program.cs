using System;

    internal class Program
{
    static void Main(string[] args)
    {
        string userNickname = "Anonymous#1337";
        string userHobby = " - ";
        string userAge = " - ";
        string userMessage;
        double userBalanceEthereum = 0.35;
        bool isExit = false;

        Console.WriteLine($"Добро пожаловать! {userNickname}.");
        Console.WriteLine("Введите Info, чтобы узнать какие команды есть.");
        Console.WriteLine("Введите команду в консоль:");

        while (isExit == false)
        {
            userMessage = Console.ReadLine();

            switch (userMessage.ToLower())
            {
                case "info":
                    Console.WriteLine("SetNickname - Поменять ник.");
                    Console.WriteLine("CheckBalance - Проверить баланс.");
                    Console.WriteLine("SetHobby - Поменять хобби.");
                    Console.WriteLine("ProfileInfo - Посмотреть свой профиль.");
                    Console.WriteLine("SetAge - Поменять возраст.");
                    Console.WriteLine("Exit - Выход из программы.");
                    break;
                case "setnickname":
                    Console.WriteLine("Введите новый ник:");
                    userNickname = Console.ReadLine();
                    Console.WriteLine($"Вы установили новый ник: '{userNickname}'");
                    break;
                case "sethobby":
                    Console.WriteLine("Введите свое хобби:");
                    userHobby = Console.ReadLine();
                    Console.WriteLine($"Вы поменяли свое хобби: '{userHobby}'");
                    break;
                case "setage":
                    Console.WriteLine("Введите ваш возраст:");
                    userAge = Console.ReadLine();
                    Console.WriteLine($"Вы поменяли свой возраст: '{userAge} лет.'");
                    break;
                case "checkbalance":
                    Console.WriteLine($"Ваш баланс: {userBalanceEthereum} ETH.");
                    break;
                case "profileinfo":
                    Console.WriteLine($"Ваш никнейм: {userNickname}");
                    Console.WriteLine($"Хобби: {userHobby}");
                    Console.WriteLine($"Возраст: {userAge} лет.");
                    break;
                case "exit":
                    isExit = true;
                    break;
                default:
                    Console.WriteLine("Команда введена неверно.");
                    break;
            }
        }
    }
}