using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace consoleApp.JSON
{
    class Access
    {
        public void Run(){
            Console.WriteLine("consoleApp.JObject.Access");

            JObject jsonObj = JObject.Parse("{\"name\": \"Luke\", \"Address\": \"Tatooine\"}");
            Console.WriteLine("jsonObj.Property(\"name\").Name: " + jsonObj.Property("name").Name);
            Console.WriteLine("jsonObj.Property(\"name\").Value: " + jsonObj.Property("name").Value);
            Console.WriteLine("jsonObj.Property(\"Address\").Name: " + jsonObj.Property("Address").Name);
            Console.WriteLine("jsonObj.Property(\"Address\").Value: " + jsonObj.Property("Address").Value);

            Console.WriteLine("/consoleApp.JObject.Access");
            Console.WriteLine();
        }
    }
}
