using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nahrungsverwaltung.Classes
{
    [Serializable]
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(string name, double size, int food, bool sick, string species, int age, double foodAmount)
        {
            Name = name;
            Size = size;
            Food = food;
            Sick = sick;
            Species = species;
            Age = age;
            FoodAmount = foodAmount;
        }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Size")]
        public double Size { get; set; }

        [DisplayName("FoodType")]
        public int Food { get; set; }

        [DisplayName("Sick")]
        public bool Sick { get; set; }
        
        [DisplayName("Species")]
        public string Species { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }

        [DisplayName("Food Amount")]
        public double FoodAmount { get; set; }

        [DisplayName("Fed Food Amount")]
        public double FedFoodAmount { get; set; }
    }
}