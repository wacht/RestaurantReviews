using ApiSample.Common;
using Microsoft.AspNetCore.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Restaurant
{
    public class RestaurantDataAccess : IRestaurantDataAccess
    {
        public int AddRestaurant(CreateRestaurantModel restaurant)
        {
            //assumption: calls would usually be in using() statement

            //just return fake id
            return 99;
        }

        public IEnumerable<RestaurantModel> GetRestaurantsByCity(int cityId)
        {
            return RestaurantDataStore.Restaurants
                .Where(c => c.City.Id == cityId)
                .Select(r => new RestaurantModel {
                    RestaurantId = r.Id,
                    RestaurantName = r.Name,
                    City = new City { CityId = r.City.Id, CityName = r.City.Name}
                }).ToList();
        }
    }
}
