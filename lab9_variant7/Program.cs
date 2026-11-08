using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Athlete
{
    public string Name {get; set;}
    public string Sport {get; set;}
    public int Awards {get; set;}
    public int Age {get; set;}

    public Athlete(string name, string sport, int awards, int age)
    {
        Name = name;
        Sport = sport;
        Awards = awards;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Athlete> athletes = new List<Athlete>
        {
            new Athlete("Олександр", "Футбол", 5, 24),
            new Athlete("Андрій", "Баскетбол", 2, 21),
            new Athlete("Марія", "Плавання", 7, 19),
            new Athlete("Іван", "Футбол", 4, 27),
            new Athlete("Олена", "Плавання", 3, 22),
            new Athlete("Дмитро", "Баскетбол", 6, 25)
        };

        Console.WriteLine("1. Спортсмени з більше ніж 3 нагородами:");

        var awarded = athletes.Where(a => a.Awards > 3);

        foreach (var athlete in awarded)
        {
            Console.WriteLine($"{athlete.Name} - {athlete.Awards} нагород");
        }

        Console.WriteLine("\n2. Спортсмени за віком:");

        var sorted = athletes.OrderBy(a => a.Age);

        foreach (var athlete in sorted)
        {
            Console.WriteLine($"{athlete.Name} - {athlete.Age} років");
        }

        Console.WriteLine("\n3. Середня кількість нагород:");

        double average = athletes.Average(a => a.Awards);
        Console.WriteLine($"Середня кількість нагород: {average:F2}");

        Console.WriteLine("\n4. Спортсмени за видами спорту:");

        var grouped = athletes.GroupBy(a => a.Sport);

        foreach (var group in grouped)
        {
            Console.WriteLine($"\n{group.Key}:");

            foreach (var athlete in group)
            {
                Console.WriteLine($"{athlete.Name}");
            }
        }
    }
}
