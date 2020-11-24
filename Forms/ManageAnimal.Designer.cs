namespace Nahrungsverwaltung.Forms
{
    partial class ManageAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addAnimal = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.num_size = new System.Windows.Forms.NumericUpDown();
            this.lbl_size = new System.Windows.Forms.Label();
            this.cbox_foodtype = new System.Windows.Forms.ComboBox();
            this.lbl_foodType = new System.Windows.Forms.Label();
            this.chbox_isSick = new System.Windows.Forms.CheckBox();
            this.lbl_species = new System.Windows.Forms.Label();
            this.txt_species = new System.Windows.Forms.TextBox();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.lbl_age = new System.Windows.Forms.Label();
            this.num_foodAmount = new System.Windows.Forms.NumericUpDown();
            this.lbl_foodAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_foodAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(168, 251);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addAnimal
            // 
            this.btn_addAnimal.Location = new System.Drawing.Point(87, 251);
            this.btn_addAnimal.Name = "btn_addAnimal";
            this.btn_addAnimal.Size = new System.Drawing.Size(75, 23);
            this.btn_addAnimal.TabIndex = 1;
            this.btn_addAnimal.Text = "Add Animal";
            this.btn_addAnimal.UseVisualStyleBackColor = true;
            this.btn_addAnimal.Click += new System.EventHandler(this.btn_addAnimal_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(123, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(120, 20);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 55);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // num_size
            // 
            this.num_size.DecimalPlaces = 2;
            this.num_size.Location = new System.Drawing.Point(123, 78);
            this.num_size.Name = "num_size";
            this.num_size.Size = new System.Drawing.Size(120, 20);
            this.num_size.TabIndex = 4;
            this.num_size.Tag = "0,00";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(12, 80);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(75, 13);
            this.lbl_size.TabIndex = 5;
            this.lbl_size.Text = "Size in meters:";
            // 
            // cbox_foodtype
            // 
            this.cbox_foodtype.FormattingEnabled = true;
            this.cbox_foodtype.Location = new System.Drawing.Point(122, 104);
            this.cbox_foodtype.Name = "cbox_foodtype";
            this.cbox_foodtype.Size = new System.Drawing.Size(121, 21);
            this.cbox_foodtype.TabIndex = 6;
            // 
            // lbl_foodType
            // 
            this.lbl_foodType.AutoSize = true;
            this.lbl_foodType.Location = new System.Drawing.Point(12, 107);
            this.lbl_foodType.Name = "lbl_foodType";
            this.lbl_foodType.Size = new System.Drawing.Size(54, 13);
            this.lbl_foodType.TabIndex = 7;
            this.lbl_foodType.Text = "Foodtype:";
            // 
            // chbox_isSick
            // 
            this.chbox_isSick.AutoSize = true;
            this.chbox_isSick.Location = new System.Drawing.Point(123, 131);
            this.chbox_isSick.Name = "chbox_isSick";
            this.chbox_isSick.Size = new System.Drawing.Size(89, 17);
            this.chbox_isSick.TabIndex = 8;
            this.chbox_isSick.Text = "Animal is sick";
            this.chbox_isSick.UseVisualStyleBackColor = true;
            // 
            // lbl_species
            // 
            this.lbl_species.AutoSize = true;
            this.lbl_species.Location = new System.Drawing.Point(12, 157);
            this.lbl_species.Name = "lbl_species";
            this.lbl_species.Size = new System.Drawing.Size(48, 13);
            this.lbl_species.TabIndex = 9;
            this.lbl_species.Text = "Species:";
            // 
            // txt_species
            // 
            this.txt_species.Location = new System.Drawing.Point(123, 154);
            this.txt_species.Name = "txt_species";
            this.txt_species.Size = new System.Drawing.Size(120, 20);
            this.txt_species.TabIndex = 10;
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(122, 180);
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(120, 20);
            this.num_age.TabIndex = 11;
            this.num_age.Tag = "0";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(12, 182);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(77, 13);
            this.lbl_age.TabIndex = 12;
            this.lbl_age.Text = "Age in months:";
            // 
            // num_foodAmount
            // 
            this.num_foodAmount.DecimalPlaces = 2;
            this.num_foodAmount.Location = new System.Drawing.Point(122, 207);
            this.num_foodAmount.Name = "num_foodAmount";
            this.num_foodAmount.Size = new System.Drawing.Size(120, 20);
            this.num_foodAmount.TabIndex = 13;
            this.num_foodAmount.Tag = "0,00";
            // 
            // lbl_foodAmount
            // 
            this.lbl_foodAmount.AutoSize = true;
            this.lbl_foodAmount.Location = new System.Drawing.Point(12, 209);
            this.lbl_foodAmount.Name = "lbl_foodAmount";
            this.lbl_foodAmount.Size = new System.Drawing.Size(104, 13);
            this.lbl_foodAmount.TabIndex = 14;
            this.lbl_foodAmount.Text = "Food Amount in Kilo:";
            // 
            // ManageAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 294);
            this.Controls.Add(this.lbl_foodAmount);
            this.Controls.Add(this.num_foodAmount);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.num_age);
            this.Controls.Add(this.txt_species);
            this.Controls.Add(this.lbl_species);
            this.Controls.Add(this.chbox_isSick);
            this.Controls.Add(this.lbl_foodType);
            this.Controls.Add(this.cbox_foodtype);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.num_size);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_addAnimal);
            this.Controls.Add(this.btn_close);
            this.Name = "ManageAnimal";
            this.Text = "ManageAnimal";
            this.Load += new System.EventHandler(this.ManageAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_foodAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_addAnimal;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.NumericUpDown num_size;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.ComboBox cbox_foodtype;
        private System.Windows.Forms.Label lbl_foodType;
        private System.Windows.Forms.CheckBox chbox_isSick;
        private System.Windows.Forms.Label lbl_species;
        private System.Windows.Forms.TextBox txt_species;
        private System.Windows.Forms.NumericUpDown num_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.NumericUpDown num_foodAmount;
        private System.Windows.Forms.Label lbl_foodAmount;
    }
}