using System;

namespace ZooManagementSystem
{
    partial class frmGuestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestMenu));
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.grpGuestSelect = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoodQuantity = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFedAnimal = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToMainMenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVirtualAnimal = new System.Windows.Forms.ListBox();
            this.grpGuestSelect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.MistyRose;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(441, 86);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(426, 74);
            this.lblWelcomeMessage.TabIndex = 1;
            this.lblWelcomeMessage.Text = "Welcome to the Urban Safari Zoo";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpGuestSelect
            // 
            this.grpGuestSelect.BackColor = System.Drawing.Color.Transparent;
            this.grpGuestSelect.Controls.Add(this.label5);
            this.grpGuestSelect.Controls.Add(this.txtFoodQuantity);
            this.grpGuestSelect.Controls.Add(this.txtFood);
            this.grpGuestSelect.Controls.Add(this.label4);
            this.grpGuestSelect.Controls.Add(this.btnFedAnimal);
            this.grpGuestSelect.Controls.Add(this.btnEat);
            this.grpGuestSelect.Controls.Add(this.btnSound);
            this.grpGuestSelect.Controls.Add(this.btnMove);
            this.grpGuestSelect.Controls.Add(this.btnClear);
            this.grpGuestSelect.Controls.Add(this.cmbAnimal);
            this.grpGuestSelect.Controls.Add(this.cmbLocation);
            this.grpGuestSelect.Controls.Add(this.cmbSpecies);
            this.grpGuestSelect.Controls.Add(this.label3);
            this.grpGuestSelect.Controls.Add(this.label2);
            this.grpGuestSelect.Controls.Add(this.label1);
            this.grpGuestSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpGuestSelect.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGuestSelect.ForeColor = System.Drawing.Color.MistyRose;
            this.grpGuestSelect.Location = new System.Drawing.Point(491, 208);
            this.grpGuestSelect.Name = "grpGuestSelect";
            this.grpGuestSelect.Size = new System.Drawing.Size(490, 275);
            this.grpGuestSelect.TabIndex = 3;
            this.grpGuestSelect.TabStop = false;
            this.grpGuestSelect.Text = "Your Virtual Zoo:";
            this.grpGuestSelect.Enter += new System.EventHandler(this.grpGuestSelect_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity Of Food:";
            // 
            // txtFoodQuantity
            // 
            this.txtFoodQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodQuantity.Location = new System.Drawing.Point(256, 196);
            this.txtFoodQuantity.Name = "txtFoodQuantity";
            this.txtFoodQuantity.Size = new System.Drawing.Size(178, 23);
            this.txtFoodQuantity.TabIndex = 15;
            // 
            // txtFood
            // 
            this.txtFood.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.Location = new System.Drawing.Point(256, 152);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(178, 23);
            this.txtFood.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Food:";
            // 
            // btnFedAnimal
            // 
            this.btnFedAnimal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFedAnimal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFedAnimal.Location = new System.Drawing.Point(198, 234);
            this.btnFedAnimal.Name = "btnFedAnimal";
            this.btnFedAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnFedAnimal.TabIndex = 12;
            this.btnFedAnimal.Text = "Feed";
            this.btnFedAnimal.UseVisualStyleBackColor = true;
            this.btnFedAnimal.Click += new System.EventHandler(this.btnFedAnimal_Click);
            // 
            // btnEat
            // 
            this.btnEat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEat.Location = new System.Drawing.Point(369, 234);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(75, 23);
            this.btnEat.TabIndex = 11;
            this.btnEat.Text = "Eat";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnSound
            // 
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.Location = new System.Drawing.Point(279, 234);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 23);
            this.btnSound.TabIndex = 10;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnMove
            // 
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(117, 234);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(26, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.Color.MistyRose;
            this.cmbAnimal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(256, 116);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(178, 24);
            this.cmbAnimal.TabIndex = 6;
            this.cmbAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbAnimal_SelectedIndexChanged);
            // 
            // cmbLocation
            // 
            this.cmbLocation.BackColor = System.Drawing.Color.MistyRose;
            this.cmbLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(256, 79);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(178, 24);
            this.cmbLocation.TabIndex = 5;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.BackColor = System.Drawing.Color.MistyRose;
            this.cmbSpecies.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(257, 41);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(178, 24);
            this.cmbSpecies.TabIndex = 4;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Species:";
            // 
            // btnToMainMenu
            // 
            this.btnToMainMenu.BackColor = System.Drawing.Color.Silver;
            this.btnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnToMainMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnToMainMenu.Location = new System.Drawing.Point(12, 724);
            this.btnToMainMenu.Name = "btnToMainMenu";
            this.btnToMainMenu.Size = new System.Drawing.Size(37, 28);
            this.btnToMainMenu.TabIndex = 8;
            this.btnToMainMenu.Text = "<<";
            this.btnToMainMenu.UseVisualStyleBackColor = false;
            this.btnToMainMenu.Click += new System.EventHandler(this.btnToMainMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstVirtualAnimal);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Location = new System.Drawing.Point(491, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 263);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select Animal to view:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstVirtualAnimal
            // 
            this.lstVirtualAnimal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVirtualAnimal.FormattingEnabled = true;
            this.lstVirtualAnimal.ItemHeight = 16;
            this.lstVirtualAnimal.Location = new System.Drawing.Point(27, 43);
            this.lstVirtualAnimal.Name = "lstVirtualAnimal";
            this.lstVirtualAnimal.Size = new System.Drawing.Size(439, 196);
            this.lstVirtualAnimal.TabIndex = 0;
            // 
            // frmGuestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnToMainMenu);
            this.Controls.Add(this.grpGuestSelect);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1030, 803);
            this.Name = "frmGuestMenu";
            this.Text = "Guest Menu";
            this.Load += new System.EventHandler(this.frmGuestMenu_Load);
            this.grpGuestSelect.ResumeLayout(false);
            this.grpGuestSelect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.GroupBox grpGuestSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToMainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstVirtualAnimal;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnFedAnimal;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFoodQuantity;
    }
}