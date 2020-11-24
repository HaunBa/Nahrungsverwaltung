using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nahrungsverwaltung.Classes
{
    public class FileInteraction
    {
        public FileInteraction(string location)
        {
            Location = location;
        }

        public FileInteraction(List<Animal> list, string location)
        {
            AnimalList = list;
            Location = location;
        }


        public string Location { get; set; }
        public List<Animal> AnimalList { get; set; }

        public List<Animal> ReadFile()
        {
            List < Animal > list = new List<Animal>();
            // Reads Animals from file and save it to List
            return list;
        }

        public bool WriteFile(List<Animal> list)
        {
            // Writes List of Animals to file
            return true;
        }
    }
}
