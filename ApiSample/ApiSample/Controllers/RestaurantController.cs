using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSample.Restaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace ApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        //assumption: there would be a method of search for a city and get a city id    
        //assumption: this is a public method that does not require authorization
        [HttpGet]
        [Route("restaurant/{cityId}")]
        public IEnumerable<RestaurantModel> GetRestaurantsByCity(int cityId)
        {
            var service = new RestaurantService(new RestaurantDataAccess());
            return service.GetRestaurantsByCity(cityId);
        }

        
        //assumption: this would require authorization. 
        //             a large app would almost certainly have an attribute to handle it, but it can also be done in the method
        [HttpPut]
        [Route("restaurant/add")]
        //[Permission("AddRestaurant")]
        public RestaurantModel AddRestaurant([FromBody] CreateRestaurantModel restaurant)
        {
            if (!ValidateRestaurant(restaurant)) 
                return null; //todo:  log error, return error message

            if (!User.IsInRole("AddRestaurant"))
                return null; //todo:  log error, return unauthorized

            var service = new RestaurantService(new RestaurantDataAccess());
            
            // assumption: (not shown) all write operations would normally receive user information from the controller
            return service.AddRestaurant(restaurant);
        }

        // assumption: we would valid a creation model as valid
        // it wouldn't need to go here, this is just an example
        // it could be on the model, a static extension method, a service call...
        private bool ValidateRestaurant(CreateRestaurantModel restaurant)
        {
            return restaurant.RestaurantName != null && restaurant.CityId > 0; 
        }
    }


}
