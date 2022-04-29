using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Linq
{
    internal class CarData
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("car_make")]
        public string Make { get; set; }
        [JsonPropertyName("car_models")]
        public string Model { get; set; }
        [JsonPropertyName("car_year")]
        public int Year { get; set; }
        [JsonPropertyName("number_of_doors")]
        public int NumberOfDoors { get; set; }
        [JsonPropertyName("hp")]
        public int HP { get; set; }

    }

}
