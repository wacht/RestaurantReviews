using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Restaurant
{
    public class RestaurantDataAccess : IRestaurantDataAccess
    {
        public RestaurantModel AddRestaurant(CreateRestaurantModel restaurant)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RestaurantModel> GetRestaurantsByCity(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
