using AnimalHusbandry.Model.Structs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandry.Model.Classes
{
    public sealed class Sheep : Animal
    {

        public static int Number;

        public Sheep(int ID,
                   int MaxLife,
                   bool Gender,
                   double Weight,
                   List<AnimalEnvironment> Environments,
                   List<Product> Products,
                   List<Cost> Costs)
        {
            this.ID = ID;
            this.MaxLife = MaxLife;
            this.Gender = Gender;
            this.Weight = Weight;
            this.Environments = Environments;
            this.Products = Products;
            this.Costs = Costs;
            Number++;
            char GenderChar = ' ';
            if (this.Gender == true)
            {
                GenderChar = 'M';
            }
            else
            {
                GenderChar = 'F';
            }
            BirthDate = DateTime.Today;

            Name = $"S{GenderChar}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}{ID}";
        }

        public override string ToString() => $"Name: {Name} BirthDate: {BirthDate} Age: {Math.Round((double)Life() / 365, 0)}";




    }
}
