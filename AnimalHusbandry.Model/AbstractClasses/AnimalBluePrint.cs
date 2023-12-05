using AnimalHusbandry.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHusbandry.Model.Structs;
using AnimalHusbandry.Model.Classes;

namespace AnimalHusbandry.Model.AbstractClasses
{
    public abstract class AnimalBluePrint
    {
        public int ID { get; init; }

        public string Name { get; init; }

        public DateTime BirthDate { get; init; }

        public int MaxLife { get; set; }

        public List<IAnimalEnvironment> Environments { get; set; }

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }

        public double Weight { get; set; }

        public bool Gender { get; set; }

        public abstract double AverageStressFactor(AnimalEnvironment Environment);

        public abstract int Life();

        public abstract int TimeToDie();

        public abstract double KillPriority();

        public abstract decimal CostPerDay();

        public abstract decimal IncomePerDay();
    }
}
