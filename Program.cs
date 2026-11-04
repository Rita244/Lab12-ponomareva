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

// using System;

// public enum CharacterClass
// {
//     Warrior,
//     Mage,
//     Archer
// }

// public class GameCharacter
// {
//     public string Name { get; set; }
//     public CharacterClass Class { get; set; }
//     public int? Age { get; set; }
//     public int? Wins { get; set; }
//     public double? Bonus { get; set; }

//     public void DisplayInfo()
//     {
//         Console.WriteLine("--- Персонаж ---");
//         Console.WriteLine($"Имя: {Name}");
//         Console.WriteLine($"Класс: {Class}");
//         Console.WriteLine($"Описание: {GetClassDescription(Class)}");
//         Console.WriteLine($"Возраст: {(Age.HasValue ? Age.ToString() : "не указан")}");
//         Console.WriteLine($"Победы: {(Wins.HasValue ? Wins.ToString() : "не указано")}");
//         Console.WriteLine($"Бонус: {(Bonus.HasValue ? Bonus.ToString() : "не указан")}");
//         Console.WriteLine("----------------");
//     }

//     private string GetClassDescription(CharacterClass charClass)
//     {
//         switch (charClass)
//         {
//             case CharacterClass.Warrior:
//                 return "Использует меч";
//             case CharacterClass.Mage:
//                 return "Использует магию";
//             case CharacterClass.Archer:
//                 return "Использует лук";
//             default:
//                 return "Неизвестный класс";
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         GameCharacter hero = new GameCharacter();

//         Console.Write("Имя: ");
//         hero.Name = Console.ReadLine();

//         Console.Write("Класс (Warrior/Mage/Archer): ");
//         string classInput = Console.ReadLine();

//         if (Enum.TryParse(classInput, true, out CharacterClass parsedClass))
//         {
//             hero.Class = parsedClass;
//         }
//         else
//         {
//             Console.WriteLine("Ошибка: Неверный класс. Установлен по умолчанию (Warrior).");
//             hero.Class = CharacterClass.Warrior;
//         }

//         Console.Write("Возраст: ");
//         string ageInput = Console.ReadLine();
//         if (int.TryParse(ageInput, out int age))
//         {
//             hero.Age = age;
//         }
//         else
//         {
//             hero.Age = null;
//         }

//         Console.Write("Количество побед: ");
//         string winsInput = Console.ReadLine();
//         if (int.TryParse(winsInput, out int wins))
//         {
//             hero.Wins = wins;
//         }
//         else
//         {
//             hero.Wins = null;
//         }

//         hero.Bonus = 1.5;

//         hero.DisplayInfo();
//     }
// }



// ## Самостоятельные задания

// ### ★ Enum

// using System;

// public enum TrafficLight
// {
//     Red,
//     Yellow,
//     Green
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         Console.WriteLine(GetTrafficRecommendation(TrafficLight.Red));
//         Console.WriteLine(GetTrafficRecommendation(TrafficLight.Yellow));
//         Console.WriteLine(GetTrafficRecommendation(TrafficLight.Green));
//         Console.WriteLine();

//         Console.WriteLine($"Сумма (5, 10): {CalculateSum(5, 10)}");
//         Console.WriteLine($"Сумма (5, null): {CalculateSum(5, null)}");
//         Console.WriteLine($"Сумма (null, null): {CalculateSum(null, null)}");
//     }

//     public static string GetTrafficRecommendation(TrafficLight light)
//     {
//         switch (light)
//         {
//             case TrafficLight.Red:
//                 return "Стоп";
//             case TrafficLight.Yellow:
//                 return "Внимание";
//             case TrafficLight.Green:
//                 return "Можно идти";
//             default:
//                 return "Неизвестный сигнал";
//         }
//     }

//     public static int? CalculateSum(int? a, int? b)
//     {
//         if (a == null || b == null)
//         {
//             return null;
//         }

//         return a + b;
//     }
// }


// ### ★★ Nullable

// using System;

// public enum TrafficLight
// {
//     Red,
//     Yellow,
//     Green
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(GetTrafficRecommendation(TrafficLight.Red));
//         Console.WriteLine(GetTrafficRecommendation(TrafficLight.Yellow));
//         Console.WriteLine(GetTrafficRecommendation(TrafficLight.Green));
//         Console.WriteLine();

//         Console.WriteLine($"Сумма (5, 10): {CalculateSum(5, 10)}");
//         Console.WriteLine($"Сумма (5, null): {CalculateSum(5, null)}");
//         Console.WriteLine($"Сумма (null, null): {CalculateSum(null, null)}");
//     }

//     public static string GetTrafficRecommendation(TrafficLight light)
//     {
//         switch (light)
//         {
//             case TrafficLight.Red:
//                 return "Стоп";
//             case TrafficLight.Yellow:
//                 return "Внимание";
//             case TrafficLight.Green:
//                 return "Можно идти";
//             default:
//                 return "Неизвестный сигнал";
//         }
//     }

//     public static int? CalculateSum(int? a, int? b)

//         if (a == null || b == null)
//         {
//             return null;
//         }
        
//         return a + b;
//     }
// }


// ### ★★★ Комбинированная задача

using System;

public enum ItemRarity
{
    Common,
    Rare,
    Legendary
}

public class GameItem
{
    public string Name { get; set; }
    public ItemRarity Rarity { get; set; }
    public int? Damage { get; set; }
    public int? Durability { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"--- Предмет: {Name} ---");
        Console.WriteLine($"Редкость: {Rarity}");
        Console.WriteLine($"Урон: {Damage?.ToString() ?? "нет"}");
        Console.WriteLine($"Прочность: {Durability?.ToString() ?? "неизвестна"}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameItem sword = new GameItem { Name = "Меч", Rarity = ItemRarity.Rare, Damage = 15, Durability = 100 };
        GameItem potion = new GameItem { Name = "Зелье", Rarity = ItemRarity.Common, Damage = null, Durability = null };
        GameItem ring = new GameItem { Name = "Кольцо силы", Rarity = ItemRarity.Legendary, Damage = null, Durability = 50 };

        sword.ShowInfo();
        potion.ShowInfo();
        ring.ShowInfo();

        Console.WriteLine("--- Рекомендация по использованию ---");
        Console.WriteLine(GetRarityAdvice(sword.Rarity));
        Console.WriteLine(GetRarityAdvice(potion.Rarity));
        Console.WriteLine(GetRarityAdvice(ring.Rarity));
    }

    public static string GetRarityAdvice(ItemRarity rarity)
    {
        switch (rarity)
        {
            case ItemRarity.Common:
                return "Можно использовать без опаски.";
            case ItemRarity.Rare:
                return "Берегите этот предмет!";
            case ItemRarity.Legendary:
                return "Использовать только в крайнем случае!";
            default:
                return "Неизвестная редкость.";
        }
    }
}