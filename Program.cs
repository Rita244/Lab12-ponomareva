// using System;

// enum Difficulty
// {
//     Easy,
//     Normal,
//     Hard
// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите название уровня сложности: ");
//         string input = Console.ReadLine();

//         bool success = Enum.TryParse(input, true, out Difficulty selectedLevel);

//         if (success && Enum.IsDefined(typeof(Difficulty), selectedLevel))
//         {
//             Console.WriteLine("Значение введено корректно.");
//             Console.WriteLine($"Выбран уровень: {selectedLevel}");
//         }
//         else
//         {
//             Console.WriteLine("Значение введено некорректно.");
//         }
//     }
// }


// ## Итоговая задача. Параметры персонажа

using System;

public enum CharacterClass
{
    Warrior,
    Mage,
    Archer
}

public class GameCharacter
{
    public string Name { get; set; }
    public CharacterClass Class { get; set; }
    public int? Age { get; set; }
    public int? Wins { get; set; }
    public double? Bonus { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("--- Персонаж ---");
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Класс: {Class}");
        Console.WriteLine($"Описание: {GetClassDescription(Class)}");
        Console.WriteLine($"Возраст: {(Age.HasValue ? Age.ToString() : "не указан")}");
        Console.WriteLine($"Победы: {(Wins.HasValue ? Wins.ToString() : "не указано")}");
        Console.WriteLine($"Бонус: {(Bonus.HasValue ? Bonus.ToString() : "не указан")}");
        Console.WriteLine("----------------");
    }

    private string GetClassDescription(CharacterClass charClass)
    {
        switch (charClass)
        {
            case CharacterClass.Warrior:
                return "Использует меч";
            case CharacterClass.Mage:
                return "Использует магию";
            case CharacterClass.Archer:
                return "Использует лук";
            default:
                return "Неизвестный класс";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameCharacter hero = new GameCharacter();

        Console.Write("Имя: ");
        hero.Name = Console.ReadLine();

        Console.Write("Класс (Warrior/Mage/Archer): ");
        string classInput = Console.ReadLine();
        
        if (Enum.TryParse(classInput, true, out CharacterClass parsedClass))
        {
            hero.Class = parsedClass;
        }
        else
        {
            Console.WriteLine("Ошибка: Неверный класс. Установлен по умолчанию (Warrior).");
            hero.Class = CharacterClass.Warrior;
        }

        Console.Write("Возраст: ");
        string ageInput = Console.ReadLine();
        if (int.TryParse(ageInput, out int age))
        {
            hero.Age = age;
        }
        else
        {
            hero.Age = null;
        }

        Console.Write("Количество побед: ");
        string winsInput = Console.ReadLine();
        if (int.TryParse(winsInput, out int wins))
        {
            hero.Wins = wins;
        }
        else
        {
            hero.Wins = null;
        }

        hero.Bonus = 1.5;

        hero.DisplayInfo();
    }
}