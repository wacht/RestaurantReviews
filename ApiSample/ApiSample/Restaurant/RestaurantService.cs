using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return null;
        }

        //assumption: we would expect user information as well
        public RestaurantModel AddRestaurant(CreateRestaurantModel restaurant)
        {
            return null;
        }
        
    }
}
