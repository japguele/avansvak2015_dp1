using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CircuitSimulater
{
    class FileController
    {
        private string filePath { get; set; }
        private string[] lines { get; set; }

        public FileController(string filePath)
        {
            this.filePath = filePath;
            ReadFile();
            MakeObjects();
        }

        private void ReadFile()
        {
            lines = System.IO.File.ReadAllLines(@filePath);
            Console.Write(lines);
        }

        private void MakeObjects()
        {
            Dictionary<string, string[]> nodes = new Dictionary<string, string[]>();
            Dictionary<string, string[]> edges = new Dictionary<string, string[]>();

            foreach (string line in lines)
            {
                if (!line.StartsWith("#"))
                {
                    Regex rgx = new Regex(@"([A-Z a-z 0-9])+:\s*([A-Z a-z 0-9 _])+(,([A-Z a-z 0-9 _])*)*;");
                    if (rgx.IsMatch(line))
                    {
                        // Split op de : voor key, value pair
                        string[] data = line.Split(':');

                        // Pakt de tekst voor de : als key en verwijderd spaties
                        string name = data[0].Trim();

                        // Pakt de tekst na de : als value, verwijderd spaties en de ; en splitst naar een array op de ,
                        string description = data[1].Trim().Replace(";", String.Empty);
                        string[] arrDescription = description.Split(',');

                        // Als de key bestaat in nodes, is het een edge
                        if (nodes.ContainsKey(name))
                        {
                            edges.Add(name, arrDescription);
                        }
                        else
                        {
                            nodes.Add(name, arrDescription);
                        }
                    }
                }
            }

        }
    }
}
