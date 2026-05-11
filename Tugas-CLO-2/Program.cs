using Microsoft.Extensions.Configuration;
using Tugas_CLO_2.Models;
using Tugas_CLO_2.Services;
using Tugas_CLO_2.Helpers;

namespace Tugas_CLO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string apiKey = config["GoogleMapsApiKey"];

            Console.WriteLine("=== GOODBITE LOCATION SYSTEM ===\n");

            List<Store> stores = new List<Store>
            {
                new Store
                {
                    Name = "Food Paradise",
                    Latitude = -6.914744,
                    Longitude = 107.609810
                },

                new Store
                {
                    Name = "Healthy Food Corner",
                    Latitude = -6.917464,
                    Longitude = 107.619123
                },

                new Store
                {
                    Name = "Good Meal Cafe",
                    Latitude = -6.920000,
                    Longitude = 107.610000
                }
            };

            Console.Write("Masukkan latitude user: ");
            double userLat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan longitude user: ");
            double userLon = Convert.ToDouble(Console.ReadLine());

            ValidationHelper.ValidateCoordinate(userLat, userLon);

            Console.WriteLine("\n=== DAFTAR TOKO TERDEKAT ===\n");

            foreach (var store in stores)
            {
                double distance = DistanceService.CalculateDistance(
                    userLat,
                    userLon,
                    store.Latitude,
                    store.Longitude
                );

                Console.WriteLine($"Nama Toko : {store.Name}");
                Console.WriteLine($"Jarak     : {distance:F2} KM\n");
            }

            Console.WriteLine("Google Maps API Loaded");
            Console.WriteLine($"API KEY : {apiKey}");
        }
    }
}