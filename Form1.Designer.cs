namespace Nahrungsverwaltung
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_removeAnimal = new System.Windows.Forms.Button();
            this.btn_GetFoodUsage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_GetFoodUsagePerWeek = new System.Windows.Forms.Button();
            this.btn_editAnimal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_feedAnimal = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_removeAnimal
            // 
            this.btn_removeAnimal.Location = new System.Drawing.Point(213, 168);
            this.btn_removeAnimal.Name = "btn_removeAnimal";
            this.btn_removeAnimal.Size = new System.Drawing.Size(95, 23);
            this.btn_removeAnimal.TabIndex = 2;
            this.btn_removeAnimal.Text = "RemoveAnimal";
            this.btn_removeAnimal.UseVisualStyleBackColor = true;
            this.btn_removeAnimal.Click += new System.EventHandler(this.Btn_removeAnimal_Click);
            // 
            // btn_GetFoodUsage
            // 
            this.btn_GetFoodUsage.Location = new System.Drawing.Point(13, 43);
            this.btn_GetFoodUsage.Name = "btn_GetFoodUsage";
            this.btn_GetFoodUsage.Size = new System.Drawing.Size(75, 23);
            this.btn_GetFoodUsage.TabIndex = 3;
            this.btn_GetFoodUsage.Text = "GetFoodUsage";
            this.btn_GetFoodUsage.UseVisualStyleBackColor = true;
            this.btn_GetFoodUsage.Click += new System.EventHandler(this.Btn_GetFoodUsage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddAnimal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_addAnimal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Estimated Food Usage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_GetFoodUsage_Click);
            // 
            // btn_GetFoodUsagePerWeek
            // 
            this.btn_GetFoodUsagePerWeek.Location = new System.Drawing.Point(12, 72);
            this.btn_GetFoodUsagePerWeek.Name = "btn_GetFoodUsagePerWeek";
            this.btn_GetFoodUsagePerWeek.Size = new System.Drawing.Size(194, 23);
            this.btn_GetFoodUsagePerWeek.TabIndex = 4;
            this.btn_GetFoodUsagePerWeek.Text = "Get Estimated Food Usage Per Week";
            this.btn_GetFoodUsagePerWeek.UseVisualStyleBackColor = true;
            this.btn_GetFoodUsagePerWeek.Click += new System.EventHandler(this.Btn_GetFoodUsagePerWeek_Click);
            // 
            // btn_editAnimal
            // 
            this.btn_editAnimal.Location = new System.Drawing.Point(415, 168);
            this.btn_editAnimal.Name = "btn_editAnimal";
            this.btn_editAnimal.Size = new System.Drawing.Size(95, 23);
            this.btn_editAnimal.TabIndex = 6;
            this.btn_editAnimal.Text = "Edit Animal";
            this.btn_editAnimal.UseVisualStyleBackColor = true;
            this.btn_editAnimal.Click += new System.EventHandler(this.Btn_editAnimal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalName,
            this.AnimalSize,
            this.Food,
            this.Sick,
            this.Species,
            this.Age,
            this.FoodAmount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // AnimalName
            // 
            this.AnimalName.HeaderText = "Name";
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.ReadOnly = true;
            // 
            // AnimalSize
            // 
            this.AnimalSize.HeaderText = "Size";
            this.AnimalSize.Name = "AnimalSize";
            this.AnimalSize.ReadOnly = true;
            // 
            // Food
            // 
            this.Food.HeaderText = "Food";
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            // 
            // Sick
            // 
            this.Sick.HeaderText = "Sick";
            this.Sick.Name = "Sick";
            this.Sick.ReadOnly = true;
            // 
            // Species
            // 
            this.Species.HeaderText = "Species";
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // FoodAmount
            // 
            this.FoodAmount.HeaderText = "FoodAmount";
            this.FoodAmount.Name = "FoodAmount";
            this.FoodAmount.ReadOnly = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 517);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_feedAnimal
            // 
            this.btn_feedAnimal.Location = new System.Drawing.Point(516, 168);
            this.btn_feedAnimal.Name = "btn_feedAnimal";
            this.btn_feedAnimal.Size = new System.Drawing.Size(75, 23);
            this.btn_feedAnimal.TabIndex = 9;
            this.btn_feedAnimal.Text = "feed Animal";
            this.btn_feedAnimal.UseVisualStyleBackColor = true;
            this.btn_feedAnimal.Click += new System.EventHandler(this.Btn_feedAnimal_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 60000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 552);
            this.Controls.Add(this.btn_feedAnimal);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_editAnimal);
            this.Controls.Add(this.btn_GetFoodUsagePerWeek);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_GetFoodUsage);
            this.Controls.Add(this.btn_removeAnimal);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_removeAnimal;
        private System.Windows.Forms.Button btn_GetFoodUsage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_GetFoodUsagePerWeek;
        private System.Windows.Forms.Button btn_editAnimal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAmount;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_feedAnimal;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}

