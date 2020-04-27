using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Car:RollingStock
    {
        public decimal horsePowerRequired = 0;

        public Car()
        {

        }

        public Car(string name, decimal requiredPower)
        {
            this.name = name;
            this.horsePowerRequired = requiredPower;
        }
    }
}
