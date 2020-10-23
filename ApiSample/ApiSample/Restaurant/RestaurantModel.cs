using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Restaurant
{
    public class RestaurantModel
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }        
        public City City { get; set; }
    }

    public class CreateRestaurantModel
    {
        public string RestaurantName { get; set; }
        public int CityId { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }

}
