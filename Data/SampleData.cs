namespace lab4.Data;

public class SampleData
{
    public static List<Province> GetProvinces()
    {
        List<Province> Provinces = new List<Province>() {
         new Province() {
             ProvinceCode="BC",
             ProvinceName="British Columbia",
         },
         new Province() {
             ProvinceCode="AB",
             ProvinceName="Alberta",
         },
         new Province() {
             ProvinceCode="ON",
             ProvinceName="Ontario",
         },
      };

        return Provinces;
    }

    public static List<City> GetCities()
    {
        List<City> Cities = new List<City>() {
         new City {
             CityId = 1,
             CityName = "Vancouver",
             Population = 9000000,
             ProvinceCode = "BC",
         },
        new City {
             CityId = 2,
             CityName = "Victoria",
             Population = 1000000,
             ProvinceCode = "BC",
         },
         new City {
             CityId = 3,
             CityName = "Surrey",
             Population = 1200000,
             ProvinceCode = "BC",
         },
        new City {
             CityId = 4,
             CityName = "Edmonton",
             Population = 2000000,
             ProvinceCode = "AB",
         },
        new City {
             CityId = 5,
             CityName = "Calgary",
             Population = 1500000,
             ProvinceCode = "AB",
         },
         new City {
             CityId = 6,
             CityName = "Lethbridge",
             Population = 900000,
             ProvinceCode = "AB",
         },
        new City {
             CityId = 7,
             CityName = "Ottawa",
             Population = 4000000,
             ProvinceCode = "AB",
         },
        new City {
             CityId = 8,
             CityName = "Toronto",
             Population = 3000000,
             ProvinceCode = "AB",
         },
         new City {
             CityId = 9,
             CityName = "Hamilton",
             Population = 500000,
             ProvinceCode = "AB",
         },
      };

        return Cities;
    }

}