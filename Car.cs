using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Car:RollingStock
    {
        //this is hp needed to move this car when it is empty.
        public decimal horsePowerRequiredEmptyCar = 0;

        public Car()
        {

        }

        public Car(string name, decimal requiredPower)
        {
            this.name = name;
            this.horsePowerRequiredEmptyCar = requiredPower;
        }

        public decimal CalculaterequiredHorsePower()
        {
                throw new NotImplementedException();
           
        }
    }
}
