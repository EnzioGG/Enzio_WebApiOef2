using Enzio_WebApiOef2.Models;
using System.Collections.Generic;

namespace Enzio_WebApiOef2.Services
{
    public interface IBikeService
    {
        Bike GetBike(string bikeName);
        List<Bike> GetBikes();
        void AddBike(Bike newBike);
        void DeleteBikeById(int bikeId);
        Bike UpdateBikeById(int bikeIdToEdit, Bike bikeEditValues);
    }
}