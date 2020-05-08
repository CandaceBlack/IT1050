using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger [] Occupants;
        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double currentWeight = 0;
            foreach (Passenger passenger in Occupants)
            {
                currentWeight += passenger.GetWeight();
            }
            return currentWeight;
        }
        public bool isOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
