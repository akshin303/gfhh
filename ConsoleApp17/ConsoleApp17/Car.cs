using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    internal class Car:Vehicle
    {
        public Car(int AddFuel)
        {
            
            if(AddFuel <= FuelCapacity-CurrentFuel ) 
            {
                CurrentFuel += AddFuel;
            }
            else
            {
                this.AddFuel = AddFuel;
            }

        }
        public int AddFuel;
        public int FuelCapacity = 100;
        public int CurrentFuel = 30;
    }
}
