using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace consoleApp.JSON
{
    class Deserialize
    {
        public void Run(){
            Console.WriteLine("consoleApp.JSON.Serialize");

            string toDeserializeStr = "[" +
                "{\"Name\":\"Luke\",\"Address\":\"Alderaan\",\"Age\":19,\"Person Height\":178,\"Phone\":[1111,3333,444]}," +
                "{\"Name\":\"Anakin\",\"Address\":\"Deathstar\",\"Age\":33,\"Person Height\":190,\"Phone\":[123,333,443]}" +
                "]";
            List<ToSerialize> toDeserialize = JsonConvert.DeserializeObject<List<ToSerialize>>(toDeserializeStr);
            Console.WriteLine("JsonConvert.DeserializeObject<List<ToSerialize>>(toDeserialize).Length: " + toDeserialize.Count);
            Console.WriteLine("JsonConvert.DeserializeObject<List<ToSerialize>>(toDeserialize).First().Name: " + toDeserialize.First().Name);
            Console.WriteLine("JsonConvert.DeserializeObject<List<ToSerialize>>(toDeserialize).First().Height: " + toDeserialize.First().Height.ToString());

            Console.WriteLine("/consoleApp.JSON.Serialize");
            Console.WriteLine();
        }
    }
}
