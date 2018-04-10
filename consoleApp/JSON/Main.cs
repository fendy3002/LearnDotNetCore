using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace consoleApp.JSON
{
    class Main
    {
        public void Run(){
            new Access().Run();
            new Serialize().Run();
        }
    }
}
