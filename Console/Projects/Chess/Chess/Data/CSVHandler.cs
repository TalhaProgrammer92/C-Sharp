using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Data
{
    class CSVHandler
    {
        // Attributes
        char separator;

        // Constructor
        public CSVHandler(char separator = ',')
        {
            this.separator = separator;
        }

        // Method - Read CSV file and return a list of string arrays
        public List<string[]> ReadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(separator);
                        data.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
            }
            return data;
        }

        // Method - Write data to CSV file
        public void WriteCSV(string filePath, List<string[]> data)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    foreach (var row in data)
                    {
                        string line = string.Join(separator, row);
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to CSV file: {ex.Message}");
            }
        }
    }
}
