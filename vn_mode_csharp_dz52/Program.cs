using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private const string BeforeAmnestyMessage = "Список заключенных до амнистии:";
    private const string AfterAmnestyMessage = "\nСписок заключенных после амнистии:";

    static void Main(string[] args)
    {
        List<Prisoner> prisoners = new List<Prisoner>()
        {
            new Prisoner("Иванов Иван Иванович", "Антиправительственное"),
            new Prisoner("Петров Петр Петрович", "Убийство"),
            new Prisoner("Сидоров Сидор Сидорович", "Антиправительственное"),
            new Prisoner("Смирнов Александр Александрович", "Грабеж"),
            new Prisoner("Кузнецов Дмитрий Иванович", "Антиправительственное")
        };

        DisplayPrisoners(BeforeAmnestyMessage, prisoners);

        prisoners = ExcludeAntigovernmentPrisoners(prisoners);

        DisplayPrisoners(AfterAmnestyMessage, prisoners);
    }

    static void DisplayPrisoners(string message, List<Prisoner> prisoners)
    {
        Console.WriteLine(message);

        foreach (var prisoner in prisoners)
        {
            Console.WriteLine($"{prisoner.FullName} - {prisoner.Crime}");
        }
    }

    static List<Prisoner> ExcludeAntigovernmentPrisoners(List<Prisoner> prisoners)
    {
        return prisoners.Where(prisoner => prisoner.Crime != "Антиправительственное").ToList();
    }
}

class Prisoner
{
    public string FullName { get; private set; }
    public string Crime { get; private set; }

    public Prisoner(string fullName, string crime)
    {
        FullName = fullName;
        Crime = crime;
    }
}
