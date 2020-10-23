using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Restaurant
{
    public interface IRestaurantDataAccess
    {
        IEnumerable<RestaurantModel> GetRestaurantsByCity(int cityId);

        RestaurantModel AddRestaurant(CreateRestaurantModel restaurant);
    }
}
