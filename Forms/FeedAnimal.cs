using Nahrungsverwaltung.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nahrungsverwaltung.Forms
{
    public partial class FeedAnimal : Form
    {
        public FeedAnimal()
        {
            InitializeComponent();
        }

        public decimal FoodAmount { get; set; }
        public Animal SaveFeedAnimal { get; set; }

        public FeedAnimal(Animal animal, List<Animal> animalList)
        {
            InitializeComponent();

            SaveAnimal = animal;
            AnimalList = animalList;
            FillComboBox();
            cbox_selectedAnimal.SelectedValue = SaveAnimal.Name;
        }

        private void FillComboBox()
        {
            foreach (var item in AnimalList)
            {
                cbox_selectedAnimal.Items.Add(item.Name);
            }
        }

        public Animal SaveAnimal { get; set; }
        public List<Animal> AnimalList { get; set; }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btn_feed_Click(object sender, EventArgs e)
        {
            Animal selectedAnimal = findAnimal(cbox_selectedAnimal.SelectedText);
            if (selectedAnimal != null)
            {
                SaveFeedAnimal = selectedAnimal;
                selectedAnimal.FedFoodAmount = Convert.ToDouble(num_foodAmount.Value);
                FoodAmount = num_foodAmount.Value;



                DialogResult = DialogResult.OK;
                Thread.Sleep(300);

                Close();
            }
            else
            {
                MessageBox.Show("Tier wurde nicht gefunden.", "", MessageBoxButtons.OK);
            }
        }


        Animal findAnimal(string name)
        {
            foreach (var item in AnimalList)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}