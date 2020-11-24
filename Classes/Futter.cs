using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nahrungsverwaltung.Classes
{
    public class Futter
    {
        public Futter()
        {

        }

        public enum FutterArten
        {
            Fleisch = 0,
            Korn = 1,
            Pflanze = 2,
            Fisch = 3
        }

        public string GetFoodTypeString(int val)
        {
            switch (val)
            {
                case 0:
                    return "Fleisch";
                case 1:
                    return "Korn";
                case 2:
                    return "Pflanze";
                case 3:
                    return "Fisch";
                default:
                    return "default";
            }
        }

        private int GetFoodTypeInt(string val)
        {
            switch (val)
            {
                case "Fleisch":
                    return 0;
                case "Korn":
                    return 1;
                case "Pflanze":
                    return 2;
                case "Fisch":
                    return 3;
                default:
                    return -1;
            }
        }
    }
}