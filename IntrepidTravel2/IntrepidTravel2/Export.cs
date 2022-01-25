using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IntrepidTravel2
{
    class Export
    {
        public static void ListToCsv(List<Person> persons, string title)
        {
            //create Sorted folder if doesnt exist
            Directory.CreateDirectory("C:\\Sorted");

            var sb = new StringBuilder();
            
            if (title == "Teacher") //ignore house for teacher file
            {
                foreach (var p in persons)
                {
                    sb.AppendLine(p.Name + "," + p.Type + ",");
                }
            }
            else //include house for students files
            {
                foreach (var p in persons)
                {
                    sb.AppendLine(p.Name + "," + p.House + "," + p.Type + ",");
                }
            }

            //Export files to filepath     
            var file = sb.ToString();
            File.WriteAllText($"C:\\Sorted\\{title}.txt", file);
        }

 
    }
}
