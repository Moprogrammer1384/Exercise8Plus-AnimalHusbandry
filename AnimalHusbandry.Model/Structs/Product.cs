using AnimalHusbandry.Model.Interfaces;

namespace AnimalHusbandry.Model.Structs
{
    public struct Product : IProduct
    {
        public string Name { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal Price { get; set; }

        public double DailyProduce { get; set; }

        public override string ToString() => 
            $"Name of product:{Name}, DailyProduce: {DailyProduce}{UnitOfMeasure}, Price: {Price}";
        
    }
}