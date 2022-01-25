using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntrepidTravel2
{
    class SortData
    {
        public static List<Person> TeacherFilter(List<Person> persons)
        {
            List<Person> teachers = persons.Where(x => x.Type == "Teacher").ToList();

            return teachers;
        }
        public static List<Person> HouseFilter(List<Person> persons, string house)
        {

            List<Person> houseResult = persons.Where(x => x.Type != "Teacher").ToList();
        
            if (house == "Unknown")
            {
                houseResult = houseResult.Where(x => x.House != "Green" && x.House != "Blue" && x.House != "Red" && x.House != "Yellow").ToList();
            }
            else
            {
                houseResult = houseResult.Where(x => x.House == house).ToList();
            }

            return houseResult;

        }

    }
}
