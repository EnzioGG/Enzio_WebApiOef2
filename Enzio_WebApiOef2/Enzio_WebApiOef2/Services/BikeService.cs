using Enzio_WebApiOef2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enzio_WebApiOef2.Services
{
    public class BikeService : IBikeService
    {
        List<Bike> bikes = new List<Bike>();

        //public BikeService()
        //{
        //    if (bikes.Count == 0)
        //    {
        //        var bike1 = new Bike();
        //        bike1.Name = "B1";
        //        bike1.Weight = "10kg";
        //        bike1.Price = 1000;
        //        bikes.Add(bike1);
        //    }
        //}

        public Bike GetBike(string bikeName)
        {
            var bike = bikes.FirstOrDefault(x => x.Name == bikeName);
            return bike;
        }

        public List<Bike> GetBikes()
        {
            return bikes;
        }

        public void AddBike(Bike newBike)
        {
            bikes.Add(newBike);
        }

        public void DeleteBikeById(int bikeId)
        {
            throw new NotImplementedException();
        }

        public Bike UpdateBikeById(int bikeIdToEdit, Bike bikeEditValues)
        {
            throw new NotImplementedException();
        }
    }
}
