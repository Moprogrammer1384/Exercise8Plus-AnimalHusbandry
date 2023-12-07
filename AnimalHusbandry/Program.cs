using AnimalHusbandry;
using AnimalHusbandry.Model.Classes;
using AnimalHusbandry.Model.Structs;

List<Cow> Cows = new List<Cow>();
List<Sheep> Sheeps = new List<Sheep>();


void GenerateCows()
{
    string Path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data", "Cows.json");
    if (File.Exists(Path))
    {
        String JSONtxt = File.ReadAllText(Path);
        var _cows = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Cow>>(JSONtxt);

        foreach (var cow in _cows)
        {
            Cows.Add(cow);
        }  
    }
}

void GenerateSheeps()
{
    string Path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data", "Sheeps.json");
    if (File.Exists(Path))
    {
        String JSONtxt = File.ReadAllText(Path);
        var _sheeps = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Sheep>>(JSONtxt);

        foreach (var sheep in _sheeps)
        {
            Sheeps.Add(sheep);
        }

    }
}

void Welcome()
{
    string menu = @"
1. Show daily income of animals.
2. Show daily cost of animals.
3. Show kill priority of animals.
4. Show daily profit of animals.
5. Show meat profit of animals.
6. Exit
";
    Console.WriteLine("************************************");
    Console.WriteLine(menu);
    Console.WriteLine("************************************");
}

void SelectOption()
{
    GenerateCows();
    GenerateSheeps();
    do
    {
        Welcome();
        Console.Write("Please choose one of the options: ");
        switch (Console.ReadLine())
        {
            case "1":
                Income();
                break;
            case "2":
                Cost();
                break;
            case "3":
                KillPriority();
                break;
            case "4":
                Profit();
                break;
            case "5":
                MeatIncome();
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("!!Please enter a correct number!!");
                break;

        }
        Console.WriteLine($"Total Number Of Animals: {Cows.Count + Sheeps.Count}");
    } while (true);
}

void KillPriority()
{
    Console.WriteLine("Kill Priority Of Cows: ");

    foreach (Cow cow in Cows.OrderByDescending(c => c.KillPriority()))
    {
        Console.ForegroundColor = Tools.Color(cow.KillPriority());
        Console.WriteLine("Name:{0,12} KillPriority:{1,3} Gender:{2,6}", cow.Name, cow.KillPriority(), Tools.GenderConverter(cow.Gender));
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Kill Priority Of Sheeps: ");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.KillPriority()))
    {
        Console.ForegroundColor = Tools.Color(sheep.KillPriority());
        Console.WriteLine("Name:{0,12} KillPriority:{1,3} Gender:{2,6}", sheep.Name, sheep.KillPriority(), Tools.GenderConverter(sheep.Gender));
    }

    Console.ForegroundColor = ConsoleColor.White;
}

void Income()
{
    Console.WriteLine("Daily Income Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.IncomePerDay()))
    {
        Console.WriteLine("Name:{0:,12} Income:{1,3:N} Gender:{2,6}", cow.Name, cow.IncomePerDay(), Tools.GenderConverter(cow.Gender));
    }
    Console.WriteLine("=========================================================");

    Console.WriteLine("Daily Income Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.IncomePerDay()))
    {
        Console.WriteLine("Name:{0,12} Income:{1,3:N} Gender:{2,6}", sheep.Name, sheep.IncomePerDay(), Tools.GenderConverter(sheep.Gender));
    }
}

void Cost()
{
    Console.WriteLine("Daily Cost Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Cost:{1,3:N} Gender:{2,6}", cow.Name, cow.CostPerDay(), Tools.GenderConverter(cow.Gender));
    }
    Console.WriteLine("=========================================================");

    Console.WriteLine("Daily Cost Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Cost:{1,3:N} Gender:{2,6}", sheep.Name, sheep.CostPerDay(), Tools.GenderConverter(sheep.Gender));
    }
}

void Profit()
{
    Console.WriteLine("Daily Profit Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.IncomePerDay() - c.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Profit:{1,3:N} Gender:{2,6}", cow.Name, cow.IncomePerDay() - cow.CostPerDay(), Tools.GenderConverter(cow.Gender));
    }
    Console.WriteLine("=========================================================");

    Console.WriteLine("Daily Profit Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.IncomePerDay() - s.CostPerDay()))
    {
        Console.WriteLine("Name:{0,12} Profit:{1,3:N} Gender:{2,6}", sheep.Name, sheep.IncomePerDay() - sheep.CostPerDay(), Tools.GenderConverter(sheep.Gender));
    }
}

void MeatIncome()
{
    Console.WriteLine("Meat Income Of Cows :");

    foreach (Cow cow in Cows.OrderByDescending(c => c.MeatIncome(350000m)))
    {
        Console.WriteLine("Name:{0,12} MeatIncome:{1,3:N} Gender:{2,6}", cow.Name, cow.MeatIncome(350000m), Tools.GenderConverter(cow.Gender));
    }

    Console.WriteLine("=========================================================");

    Console.WriteLine("Meat Income Of Sheeps :");

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.MeatIncome(500000m)))
    {
        Console.WriteLine("Name:{0,12} MeatIncome:{1,3:N} Gender:{2,6}", sheep.Name, sheep.MeatIncome(500000m), Tools.GenderConverter(sheep.Gender));
    }
}

SelectOption();
Console.ReadKey();