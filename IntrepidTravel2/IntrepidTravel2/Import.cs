using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IntrepidTravel2
{
    class Import
    {
        public static string[,] LoadCSV(string filename)
        {
            // Get the file's text.
            string file = File.ReadAllText(filename);

            // Split into lines.
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int numberOfRows = lines.Length;
            int numberOfColumns = lines[0].Split(',').Length;

            // Allocate the data array.
            string[,] values = new string[numberOfRows, numberOfColumns];

            // Load the array.
            for (int r = 0; r < numberOfRows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < numberOfColumns; c++)
                {
                    values[r, c] = line_r[c];
                }
            }

            // Return the values.
            return values;
        }

        public static List<Person> CsvToList()
        {
            List<Person> persons = new List<Person>();
            Person person;
            while (true) {
                try
                {
                    Console.WriteLine("Enter next filepath or enter E to Export");
                    string input = Console.ReadLine();
                    if (input.Equals("E", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    string[,] values = Import.LoadCSV(input);
                    int num_rows = values.GetUpperBound(0) + 1;

                    //Read the data and add to List 
                    for (int r = 1; r < num_rows; r++)
                    {
                        person = new Person(values[r, 0], values[r, 1], values[r, 2]);
                        persons.Add(person);
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("File Not Found");
                }
            }
            return persons;
        }
    }
}
