using System;

enum Difficulty
{
    Easy,
    Normal,
    Hard
}

class Program
{
    static void Main()
    {
        Console.Write("Введите название уровня сложности: ");
        string input = Console.ReadLine();

        bool success = Enum.TryParse(input, true, out Difficulty selectedLevel);

        if (success && Enum.IsDefined(typeof(Difficulty), selectedLevel))
        {
            Console.WriteLine("Значение введено корректно.");
            Console.WriteLine($"Выбран уровень: {selectedLevel}");
        }
        else
        {
            Console.WriteLine("Значение введено некорректно.");
        }
    }
}
