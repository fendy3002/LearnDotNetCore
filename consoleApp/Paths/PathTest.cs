using System;
using System.IO;

namespace consoleApp.Paths
{
    class PathTest
    {
        public void Run(){
            Console.WriteLine("consoleApp.Paths.PathTest");
            
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Console.WriteLine("Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName: " + projectDirectory);

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Directory.GetCurrentDirectory: " + currentDirectory);

            Console.WriteLine("/consoleApp.Paths.PathTest");
            Console.WriteLine();
        }
    }
}
