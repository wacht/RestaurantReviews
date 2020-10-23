using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Restaurant
{
    /// <summary> Static classes of mock data </summary>
    public static class RestaurantDataStore
    {
        public static IEnumerable<RestaurantEntity> Restaurants => new RestaurantEntity[]
        {
            new RestaurantEntity(1, "Avor Thai", CityEntity.CranberyTownship),
            new RestaurantEntity(2, "Burgatory", CityEntity.CranberyTownship),
            new RestaurantEntity(3, "Starbucks", CityEntity.CranberyTownship),
            new RestaurantEntity(4, "Dive", CityEntity.Wexford),
            new RestaurantEntity(5, "Walnut Grill", CityEntity.Wexford),
            new RestaurantEntity(6, "Primantis", CityEntity.Pittsburgh),
            new RestaurantEntity(7, "Allegheny Sandwich Shop", CityEntity.Pittsburgh),
        };
    }



    public class RestaurantEntity
    {
        public RestaurantEntity(int id, string name, CityEntity city)
        {
            Id = id;
            Name = name;
            City = city;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CityEntity City { get; set; }
    }

    //typesafe enum for easy sample data
    public class CityEntity
    {
        public static CityEntity Pittsburgh { get { return new CityEntity(1, "Pittsburgh"); } }
        public static CityEntity CranberyTownship { get { return new CityEntity(2, "CranberryTownship"); } }
        public static CityEntity Wexford { get { return new CityEntity(3, "Wexford"); } }

        private CityEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
