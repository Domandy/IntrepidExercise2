using System;
using System.Collections.Generic;
using System.Text;

namespace IntrepidTravel2
{
    class Person
    {
        public Person(string name, string house, string type)
        {
            Name = name;
            House = house; 
            Type = type;
            
        }

        public string Name { get; set; }
        public string House { get; set; }
        public string Type { get; set; }

    }
}
