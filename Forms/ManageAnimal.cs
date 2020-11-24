using Nahrungsverwaltung.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nahrungsverwaltung.Forms
{
    public partial class ManageAnimal : Form
    {
        // edit Animal
        public ManageAnimal(List<Animal> list, Animal animal)
        {
            InitializeComponent();
            Futter futter = new Futter();

            AnimalList = list;
            SaveAnimal = animal;

            btn_addAnimal.Text = "Save Changes";
            UpdateControls();

            // asigning Animal Class value to controls            
            txt_name.Text = SaveAnimal.Name;
            num_size.Value = Convert.ToDecimal(SaveAnimal.Size);
            cbox_foodtype.SelectedIndex = SaveAnimal.Food;
            chbox_isSick.Checked = SaveAnimal.Sick;
            txt_species.Text = SaveAnimal.Species;
            num_age.Value = SaveAnimal.Age;
            num_foodAmount.Value = Convert.ToDecimal(SaveAnimal.FoodAmount);
        }

        // add Animal
        public ManageAnimal(List<Animal> list)
        {
            InitializeComponent();
            AnimalList = list;

            btn_addAnimal.Text = "Add Animal";
        }

        public List<Animal> AnimalList { get; set; }
        public Animal SaveAnimal { get; set; }
        public double SaveFedFoodAmount { get; set; }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_addAnimal_Click(object sender, EventArgs e)
        {

            bool errorCreated = false;
            // create new ErrorProvider 
            ErrorProvider errorProvider = new ErrorProvider();

            // create new Animal and pass the input Values
            Animal animal = new Animal(

                txt_name.Text, 
                Convert.ToDouble(num_size.Value), 
                Convert.ToInt32(cbox_foodtype.SelectedItem), 
                chbox_isSick.Checked, 
                txt_species.Text,
                Convert.ToInt32(num_age.Value), 
                Convert.ToDouble(num_foodAmount.Value)
                
                );

            // checking if all textboxes are filled
            foreach (TextBox control in Controls.OfType<TextBox>())
            {
                if (control.Text == "")
                {
                    errorProvider.SetError(control, "No Text given");
                    errorCreated = true;
                }
            }
            // checking if all numericupdowns are filled
            foreach (NumericUpDown num in Controls.OfType<NumericUpDown>())
            {
                if (num.Value == Convert.ToDecimal(num.Tag))
                {
                    errorProvider.SetError(num, "No Value given");
                    errorCreated = true;
                }
            }
            // Checking if all comboboxes are filled
            foreach (ComboBox item in Controls.OfType<ComboBox>())
            {
                if (item.SelectedItem == null)
                {
                    errorProvider.SetError(item, "No Value given");
                    errorCreated = true;
                }
            }

            // detecting if animal is in the AnimalList
            if (AnimalList.Contains(animal))
            {
                MessageBox.Show("Animal with name: " + animal.Name + " is already existing", "Animal exists", MessageBoxButtons.OK);
            }
            else
            {
                if (errorCreated == false)
                {
                    AnimalList.Add(animal);
                    Close();
                }
            }


            
        }

        private void ManageAnimal_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            cbox_foodtype.Items.Clear();
            // Load All Enum types of food into Combobox
            foreach (Futter.FutterArten futter in (Futter.FutterArten[])Enum.GetValues(typeof(Futter.FutterArten)))
            {
                cbox_foodtype.Items.Add(futter);
            }
        }
    }
}
