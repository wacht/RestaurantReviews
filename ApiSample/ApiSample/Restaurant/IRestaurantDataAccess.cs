using ApiSample.Common;
using System.Collections.Generic;

namespace ApiSample.Restaurant
{
    public interface IRestaurantDataAccess
    {
        IEnumerable<RestaurantModel> GetRestaurantsByCity(int cityId);

        int AddRestaurant(CreateRestaurantModel restaurant);
    }
}
