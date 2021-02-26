using Enzio_WebApiOef2.Models;
using Enzio_WebApiOef2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enzio_WebApiOef2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeService _bikeService;
        public BikeController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        [HttpGet("All")]
        public ActionResult<List<Bike>> GetAllBikes()
        {
            var bikes = _bikeService.GetBikes();
            return Ok(bikes);
        }

        [HttpGet("One")]
        public ActionResult<Bike> GetBike(string bikeName)
        {
            var bike = _bikeService.GetBike(bikeName);
            if (bike == null)
            {
                return NotFound();
            }
            return Ok(bike);
        }

        [HttpPost]
        public ActionResult CreateNewBike(Bike newBike)
        {
            _bikeService.AddBike(newBike);
            return Ok();
        }
        
        [HttpDelete]
        public ActionResult DeleteBikeById(int bikeId)
        {
            _bikeService.DeleteBikeById(bikeId);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Bike> UpdateBikeById(int bikeIdToEdit, Bike bikeEditValues)
        {
            var updateBike = _bikeService.UpdateBikeById(bikeIdToEdit, bikeEditValues);
            return Ok(updateBike);
        }
    }
}
