using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandry.Model.Interfaces
{
    internal interface IHealthParameter<T>
    {
        public string Name { get; set; }

        public T Current { get; set; }

        public T Standard { get; set; }

        public double StressFactor();
    }
}
