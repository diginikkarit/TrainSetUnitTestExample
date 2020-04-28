using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Train
    {
        List<RollingStock> rollingStocks = new List<RollingStock>();
		
		public bool HasLocomotive
		{
			get { return false; }
		}

		public List<RollingStock> GetRollingStocks()
		{
			throw new NotImplementedException();
		}

		public void AddCar(Car car)
		{
			rollingStocks.Add(car);
		}

		public void AddLocomotive(Locomotive locomotive)
		{
			rollingStocks.Add(locomotive);
		}

		public List<Car> GetAllCars()
		{
			throw new NotImplementedException("Need word.");
		}

		public List<Locomotive> GetAllLocomotives()
		{
			throw new NotImplementedException();
		}

		public decimal horsePowerRequired()
		{
			throw new NotImplementedException();
		}

		//Tarkastaa onko junissa vaunua.
		public bool HasCars
		{
			get { return false; }
		}

		//Laskee vaunujen vaatimukset yhteen ja vertaa junien tuottamaan voimaan.
		public bool HasEnoughHorsePower
		{
			get { return false; }
		}

		public int TestiProperty
		{
			get => default;
			set
			{
			}
		}
	}
}
