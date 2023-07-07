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

        Console.WriteLine(BeforeAmnestyMessage);

        foreach (var prisoner in prisoners)
        {
            Console.WriteLine($"{prisoner.FullName} - {prisoner.Crime}");
        }

        prisoners = prisoners.Where(p => p.Crime != "Антиправительственное").ToList();

        Console.WriteLine(AfterAmnestyMessage);

        foreach (var prisoner in prisoners)
        {
            Console.WriteLine($"{prisoner.FullName} - {prisoner.Crime}");
        }
    }
}

class Prisoner
{
    public string FullName { get; set; }
    public string Crime { get; set; }

    public Prisoner(string fullName, string crime)
    {
        FullName = fullName;
        Crime = crime;
    }
}
