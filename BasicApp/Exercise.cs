using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp
{
    public static class Exercise
    {
        public static class filesystem()
        {
            string dir = "Files";

            Directory.CreateDirectory(dir);
            var fileName = "employees.txt";
            var fullPath = Path.Combine(dir, fileName);

            if(!File.Exists(fullPath))
            {
                using(File.Create(fullPath))
                {
                }
            }

            string content = "Hello world MGQS!";

            File.WriteAllText(fullPath, content);

            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        } 

    }
}
