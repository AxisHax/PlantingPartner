using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planting_Partner.Services
{
    public class PlantService
    {
        List<Plant> plantList = new();
        public async Task<List<Plant>> GetPlants()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("plantdata.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            plantList = JsonSerializer.Deserialize(contents, PlantContext.Default.ListPlant);

            if (plantList?.Count > 0)
                return plantList;
            else
                return null;
        }
    }
}
