using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services
{
    public class CarService
    {
        private const string JSON_FILE_NAME = "cars.json";
        public List<Car> GetCars()
        {
            if (File.Exists(JSON_FILE_NAME))
            {
                var json = File.ReadAllText(JSON_FILE_NAME);
                return JsonSerializer.Deserialize<List<Car>>(json);
            }
            else
            {
                return new List<Car>();
            }
        }

        public void SaveCars(List<Car> cars)
        {

            try
            {
                var json = JsonSerializer.Serialize(cars);
                File.WriteAllText(JSON_FILE_NAME, json);
            }
            catch (Exception ex)
            {

            }
        }



    }
}
