using CarServiceCenterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services
{
    public class ManagerService
    {
        private const string JSON_FILE_NAME = "Managers.json";
        public List<Manager> GetManagers()
        {
            if (File.Exists(JSON_FILE_NAME))
            {
                var json = File.ReadAllText(JSON_FILE_NAME);
                return JsonSerializer.Deserialize<List<Manager>>(json);
            }
            else
            {
                return new List<Manager>();
            }
        }

        public void SaveManagers(List<Manager> managers)
        {
            
            try
            {
                var json = JsonSerializer.Serialize(managers);
                File.WriteAllText(JSON_FILE_NAME, json);
            }
            catch (Exception ex)
            {

            }
        }

      

    }
}
