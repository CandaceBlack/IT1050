using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Passenger
    {
        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        private string Name;
        private double Weight;

        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }
    }

}
