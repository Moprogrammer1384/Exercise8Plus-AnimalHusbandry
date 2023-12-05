using AnimalHusbandry.Model.Interfaces;

namespace AnimalHusbandry.Model.Structs
{
    public struct Cost : ICost
    {
        public string Name { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal Price { get; set; }

        public double DailyUsage { get; set; }

        public override string ToString() =>
            $"Name of product:{Name}, DailyUsage: {DailyUsage}{UnitOfMeasure}, Price: {Price}";

    }
}