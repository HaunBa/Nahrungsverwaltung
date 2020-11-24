namespace Nahrungsverwaltung.Forms
{
    partial class FeedAnimal
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
            this.num_foodAmount = new System.Windows.Forms.NumericUpDown();
            this.lbl_foodAmount = new System.Windows.Forms.Label();
            this.cbox_selectedAnimal = new System.Windows.Forms.ComboBox();
            this.lbl_selectedAnimal = new System.Windows.Forms.Label();
            this.btn_feed = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_foodAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // num_foodAmount
            // 
            this.num_foodAmount.DecimalPlaces = 2;
            this.num_foodAmount.Location = new System.Drawing.Point(117, 33);
            this.num_foodAmount.Name = "num_foodAmount";
            this.num_foodAmount.Size = new System.Drawing.Size(120, 20);
            this.num_foodAmount.TabIndex = 0;
            // 
            // lbl_foodAmount
            // 
            this.lbl_foodAmount.AutoSize = true;
            this.lbl_foodAmount.Location = new System.Drawing.Point(12, 35);
            this.lbl_foodAmount.Name = "lbl_foodAmount";
            this.lbl_foodAmount.Size = new System.Drawing.Size(99, 13);
            this.lbl_foodAmount.TabIndex = 1;
            this.lbl_foodAmount.Text = "Food Amount in kg:";
            // 
            // cbox_selectedAnimal
            // 
            this.cbox_selectedAnimal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_selectedAnimal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_selectedAnimal.FormattingEnabled = true;
            this.cbox_selectedAnimal.Location = new System.Drawing.Point(116, 6);
            this.cbox_selectedAnimal.Name = "cbox_selectedAnimal";
            this.cbox_selectedAnimal.Size = new System.Drawing.Size(121, 21);
            this.cbox_selectedAnimal.TabIndex = 2;
            // 
            // lbl_selectedAnimal
            // 
            this.lbl_selectedAnimal.AutoSize = true;
            this.lbl_selectedAnimal.Location = new System.Drawing.Point(12, 9);
            this.lbl_selectedAnimal.Name = "lbl_selectedAnimal";
            this.lbl_selectedAnimal.Size = new System.Drawing.Size(86, 13);
            this.lbl_selectedAnimal.TabIndex = 3;
            this.lbl_selectedAnimal.Text = "Selected Animal:";
            // 
            // btn_feed
            // 
            this.btn_feed.Location = new System.Drawing.Point(12, 62);
            this.btn_feed.Name = "btn_feed";
            this.btn_feed.Size = new System.Drawing.Size(86, 23);
            this.btn_feed.TabIndex = 4;
            this.btn_feed.Text = "feed";
            this.btn_feed.UseVisualStyleBackColor = true;
            this.btn_feed.Click += new System.EventHandler(this.btn_feed_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(155, 62);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(82, 23);
            this.btn_abort.TabIndex = 5;
            this.btn_abort.Text = "abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // FeedAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 97);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.btn_feed);
            this.Controls.Add(this.lbl_selectedAnimal);
            this.Controls.Add(this.cbox_selectedAnimal);
            this.Controls.Add(this.lbl_foodAmount);
            this.Controls.Add(this.num_foodAmount);
            this.Name = "FeedAnimal";
            this.Text = "FeedAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.num_foodAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_foodAmount;
        private System.Windows.Forms.Label lbl_foodAmount;
        private System.Windows.Forms.ComboBox cbox_selectedAnimal;
        private System.Windows.Forms.Label lbl_selectedAnimal;
        private System.Windows.Forms.Button btn_feed;
        private System.Windows.Forms.Button btn_abort;
    }
}