using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSample.Common;
using Microsoft.Extensions.Logging;

namespace ApiSample.Restaurant
{
    public class RestaurantService
    {
        private readonly IRestaurantDataAccess _dataAccess;

        public RestaurantService(IRestaurantDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IEnumerable<RestaurantModel> GetRestaurantsByCity(int cityId)
        {
            return _dataAccess.GetRestaurantsByCity(cityId);
        }

        
        public SaveResponse AddRestaurant(CreateRestaurantModel restaurant)
        {
            //assumption: we would expect user information as well, and would record who was creating the object
            var response = new SaveResponse();
            try
            {
                response.Id = _dataAccess.AddRestaurant(restaurant);                
            }
            catch
            {
                // assumption: exceptions would be logged, and handled gracefully vs thrown
                response.ErrorMessage = "Unable to add Restaurant";                
            }       
            return response;     
        }
        
    }
}
