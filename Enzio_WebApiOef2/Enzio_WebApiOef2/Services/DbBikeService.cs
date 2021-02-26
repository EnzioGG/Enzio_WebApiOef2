using Enzio_WebApiOef2.Db;
using Enzio_WebApiOef2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enzio_WebApiOef2.Services
{
    public class DbBikeService : IBikeService
    {
        public void AddBike(Bike newBike)
        {
            using (var db = new BikeDbContext())
            {
                db.Bikes.Add(newBike);
                db.SaveChanges();
            }
        }

        public Bike GetBike(string bikeName)
        {
            using (var db = new BikeDbContext())
            {
                var bike = db.Bikes.FirstOrDefault(bike => bike.Name == bikeName);
                return bike;
            }
        }

        public List<Bike> GetBikes()
        {
            using (var db = new BikeDbContext())
            {
                return db.Bikes.ToList();
            }
        }

        public void DeleteBikeById(int bikeId)
        {
            using (var db = new BikeDbContext())
            {
                var bikeToDelete = db.Bikes.FirstOrDefault(bike => bike.Id == bikeId);
                db.Bikes.Remove(bikeToDelete);
                db.SaveChanges();
            }
        }

        public Bike UpdateBikeById(int bikeIdToEdit, Bike bikeEditValues)
        {
            using (var db = new BikeDbContext())
            {
                var bikeToEdit = db.Bikes.First(bike => bike.Id == bikeIdToEdit);
                bikeToEdit.Price = bikeEditValues.Price;
                bikeToEdit.Weight = bikeEditValues.Weight;
                bikeToEdit.Name = bikeEditValues.Name;
                db.Bikes.Update(bikeToEdit);
                db.SaveChanges();
                return bikeToEdit;
            }
        }
    }
}
