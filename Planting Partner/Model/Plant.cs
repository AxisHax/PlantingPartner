using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Planting_Partner.Model
{
    public class Plant
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string GrowthZone { get; set; }
        public string GrowSeason { get; set; }

    }

    [JsonSerializable(typeof(List<Plant>))]
    internal sealed partial class PlantContext: JsonSerializerContext
    {

    }
}
