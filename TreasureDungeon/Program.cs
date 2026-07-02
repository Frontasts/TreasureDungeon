using System;
using System.Text;

namespace TreasureDungeon
{
    internal class Program
    {
        static void Main()
        {
            bool isRanningGame = true;
            const int PlayCommand = 1;
            const int RulleCommand = 2;
            const int ExitCommand = 3;

            // TODO: Вынести параметры буфера и окна в переменные
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (isRanningGame)
            {
                // TODO: Вынести офсеты в переменные
                PrintCenter("=== Подземелье сокровищ ===", -3);
                PrintCenter($"{PlayCommand}. Начать игру", -2);
                PrintCenter($"{RulleCommand}. Показать правила", -1);
                PrintCenter($"{ExitCommand}. Выйти", 0);
                PrintCenter($"Введите число", 1);

                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int numberCommand);

                switch (numberCommand)
                {
                    case PlayCommand:
                        Game();
                        break;

                    case RulleCommand:
                        ShowRule();
                        break;

                    case ExitCommand:
                        isRanningGame = false;
                        break;

                    default:
                        PrintCenter("Вы ввели неверное число", 6);
                        break;
                }
            }
        }

        static void Game()
        {

        }

        static void ShowRule()
        {

            Console.Clear();
            // TODO: Вынести офсеты в переменные
            PrintCenter("=== Правила игры ===", -7);
            PrintCenter("1. Чтобы победить нужно дойти до выхода", -6);
            PrintCenter("2. Ловушка наносит урон в зависимости от сложности 25 - 50", -5);
            PrintCenter("3. Если хп становиться 0 или меньше, игра завершается поражением", -4);

            PrintCenter("=== Легнда символов ===", -2);
            PrintCenter("P - игрок", -1);
            PrintCenter("▢ - пустая клетка", 0);
            PrintCenter("T - ловушка", 1);
            PrintCenter("G - золото", 2);
            PrintCenter("# - стена", 3);
            PrintCenter("E - выход", 4);

            PrintCenter("(Нажмите любую кнопку чтобы вернуться в меню)", 5);

            Console.ReadKey();
            Console.Clear();
        }

        static void PrintCenter(string text, int rowOffset = 0)
        {
            // TODO: Вынести все вычисления в переменные
            int left = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
            int top = Math.Max(0, Console.WindowHeight / 2 + rowOffset);

            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);

            Console.SetCursorPosition(left, top + 1);
        }
    }
}
