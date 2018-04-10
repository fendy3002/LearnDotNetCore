using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace consoleApp.JSON
{
    class Serialize
    {
        public void Run(){
            Console.WriteLine("consoleApp.JSON.Serialize");

            List<ToSerialize> toSerialize = new List<ToSerialize>();
            toSerialize.Add(new ToSerialize(){
                Name = "Luke",
                Address = "Alderaan",
                Age = 19,
                Height = 178,
                Phone = new int[]{1111, 3333, 444}
            });
            toSerialize.Add(new ToSerialize(){
                Name = "Anakin",
                Address = "Deathstar",
                Age = 33,
                Height = 190,
                Phone = new int[]{123, 333, 443}
            });

            var jsonResult = JsonConvert.SerializeObject(toSerialize);
            Console.WriteLine("JsonConvert.SerializeObject(toSerialize): " + jsonResult);

            Console.WriteLine("/consoleApp.JSON.Serialize");
            Console.WriteLine();
        }
    }

    class ToSerialize{
        public string Name = "";
        public string Address = "";
        public int Age = 0;
        [JsonProperty("Person Height")]
        public int Height = 0;
        public IEnumerable<int> Phone = null;
        
    }
}
