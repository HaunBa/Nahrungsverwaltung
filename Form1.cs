using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Nahrungsverwaltung.Classes;
using Nahrungsverwaltung.Forms;
using System.ComponentModel;
using System.IO;

namespace Nahrungsverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadAnimalsFromFile();
        }
       
        private void ReadAnimalsFromFile()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Haunschmied.Bastian\source\repos\Nahrungsverwaltung\Files\Animals.csv"))
            {
                var i = 0;
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    if (i == 0)
                    {
                        i++;
                    }
                    else
                    {
                        string[] cutString = line.Split(',');
                        Animal animal = new Animal(

                            cutString[0],
                            Convert.ToDouble(cutString[1]),
                            Convert.ToInt32(cutString[2]),
                            Convert.ToBoolean(cutString[3]),
                            cutString[4],
                            Convert.ToInt32(cutString[5]),
                            Convert.ToDouble(cutString[6])
                            );

                        ListOfAnimals.Add(animal);
                    }
                }
            }
            UpdateControls();
        }

        private void WriteAnimalsToFile()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Haunschmied.Bastian\source\repos\Nahrungsverwaltung\Files\Animals.csv"))
            {
                writer.WriteLine("name,size,foodType,sick,species,age,foodAmount");
                foreach (var item in ListOfAnimals)
                {
                    string joinedString = 
                          item.Name + "," 
                        + item.Size + "," 
                        + item.Food + "," 
                        + item.Sick + "," 
                        + item.Species + "," 
                        + item.Age + "," 
                        + item.FoodAmount;

                    writer.WriteLine(joinedString);
                }
            }
        }

        Animal animal = new Animal();

        List<Animal> ListOfAnimals = new List<Animal>();

        List<Animal> FedAnimalsList = new List<Animal>();
        string saveFileLocation = @"\Files\";

        private decimal saveFedFoodAmount;

        public string SaveString { get; set; }

        public string SaveAnimalName { get; set; }
        
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToShortTimeString();
            if (time == "0.00" || time == "0.01")
            {
                if (WriteFedFoodAmountToFile())
                {
                    MessageBox.Show("Saved fed FoodAmount to File", "Task Successful", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failed to save fed FoodAmount to File", "Task Failed", MessageBoxButtons.OK);
                }
            }
        }

        private bool WriteFedFoodAmountToFile()
        {
            if (FedAnimalsList.Count > 0)
            {
                using (StreamWriter writer = new StreamWriter(File.Open(saveFileLocation, FileMode.Append)))
                {
                    foreach (var item in FedAnimalsList)
                    {
                        writer.WriteLine(item.Name + "," + item.FedFoodAmount);
                    }
                }
                return true;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(File.Open(saveFileLocation, FileMode.Append)))
                {
                    writer.WriteLine("No fed Animal Saved");
                }
                return false;
            }

        }

        private void Btn_addAnimal_Click(object sender, EventArgs e)
        {
            ManageAnimal manageAnimal = new ManageAnimal(ListOfAnimals);
            var result = manageAnimal.ShowDialog();

            UpdateControls();
        }

        private void UpdateControls()
        {
            dataGridView1.Rows.Clear();
            foreach (Animal animal in ListOfAnimals)
            {                
                dataGridView1.Rows.Add(animal.Name, animal.Size, Enum.GetName(typeof(Futter.FutterArten), animal.Food), animal.Sick, animal.Species, animal.Age, animal.FoodAmount);
            }

        }

        private void Btn_removeAnimal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Bitte zuvor Item aus der Listbox wählen","Wahl ungültig!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (RemoveFromList(SaveAnimalName))
                {
                    MessageBox.Show("success", "success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("couldnt find Item", "Error", MessageBoxButtons.OK);
                }
            }
            UpdateControls();
        }

        private bool RemoveFromList(string name)
        {
            if (SaveString != null)
            {
                string[] splitString = SaveString.Split(';');

                foreach (var animal in ListOfAnimals)
                {
                    if (SaveAnimalName == animal.Name)
                    {
                        ListOfAnimals.Remove(animal);
                        return true;
                    }
                }
            }
            return false;
        }

        private double GetFoodUsage()
        {
            var foodUsage = 0.0;
            foreach (var item in ListOfAnimals)
            {
                if (!item.Sick)
                {
                    // default path
                    foodUsage += item.FoodAmount;
                }
                else
                {
                    // if sick
                    foodUsage += (item.Size / 2);
                }
            }
            return foodUsage;
        }

        private void Btn_GetFoodUsage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"FoodUsage per day: {GetFoodUsage()}", $"Foodusage", MessageBoxButtons.OK);
        }
        private void Btn_GetFoodUsagePerWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"FoodUsage per week: { GetFoodUsage() * 7}", $"Foodusage", MessageBoxButtons.OK);
        }

        private void Btn_editAnimal_Click(object sender, EventArgs e)
        {
            Animal foundAnimal = new Animal();
            if ((foundAnimal = FindAnimal(SaveAnimalName)) != null)
            {
                ManageAnimal editAnimal = new ManageAnimal(ListOfAnimals, foundAnimal);
                var result = editAnimal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ListOfAnimals.Remove(foundAnimal);
                }
            }
            else
            {
                MessageBox.Show("Tier wurde nicht gefunden.", "", MessageBoxButtons.OK);
            }
            UpdateControls();
        }

        private Animal FindAnimal(string saveAnimalName)
        {
            foreach (var animal in ListOfAnimals)
            {
                if (animal.Name == saveAnimalName)
                {
                    return animal;
                }
            }
            return null;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SaveAnimalName = row.Cells[0].Value.ToString();

                string fullString = "";
                if (dataGridView1.SelectedCells.Count == 7)
                {
                    if (row.Cells != null)
                    {
                        for (int i = row.Cells.Count - 1; i >= 0; i--)
                        {
                            fullString = String.Join(";", row.Cells[i].Value.ToString(), fullString);
                            fullString += row.Cells[i] + ";";
                        }
                    }
                    SaveString = fullString;
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            WriteAnimalsToFile();
            Close();
        }

        private void Btn_feedAnimal_Click(object sender, EventArgs e)
        {
            Animal foundAnimal = new Animal();
            if ((foundAnimal = FindAnimal(SaveAnimalName)) != null)
            {
                FeedAnimal feedAnimal = new FeedAnimal(foundAnimal, ListOfAnimals);
                saveFedFoodAmount = feedAnimal.FoodAmount;
                var result = feedAnimal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tier wurde nicht gefunden.", "", MessageBoxButtons.OK);
            }           
        }
    }
}