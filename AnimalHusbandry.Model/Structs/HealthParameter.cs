using AnimalHusbandry.Model.Interfaces;

namespace AnimalHusbandry.Model.Structs
{
    public struct HealthParameter<T> : IHealthParameter<T>
    {
        public string Name { get; set; }

        public T Current { get; set; }

        public T Standard { get; set; }

        public double Coefficient { get; set; }

        public double StressFactor()
        {
            double result = Convert.ToDouble(Current) / Convert.ToDouble(Standard);
            return Math.Round(result * Coefficient, 2);
        }

        public override string ToString()
        {
            return $"ParameterName: {Name} StandardValue: {Standard} CurrentValue: {Current}";
        }
    }
}