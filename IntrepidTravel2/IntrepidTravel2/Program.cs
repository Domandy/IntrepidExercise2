using System;
using System.Collections.Generic;

namespace IntrepidTravel2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Person> persons = Import.CsvToList();

            string[] houses = new string[] { "Blue", "Red", "Yellow", "Green", "Unknown" };

            List<Person> teachers = SortData.TeacherFilter(persons);

            Export.ListToCsv(teachers, "Teacher");
            
            foreach ( string house in houses)
            {    
                List<Person> houseList = SortData.HouseFilter(persons, house);
                Export.ListToCsv(houseList, house);
            }

            Console.WriteLine("Exported files are located at C:\\Sorted");
        }
    }
}
