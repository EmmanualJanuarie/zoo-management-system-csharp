namespace ZooManagementSystem
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.radMember = new System.Windows.Forms.RadioButton();
            this.radGuest = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(12, 240);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(426, 74);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome to the Urban Safari Zoo";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcomeMessage.Click += new System.EventHandler(this.lblWelcomeMessage_Click);
            // 
            // radMember
            // 
            this.radMember.AutoSize = true;
            this.radMember.BackColor = System.Drawing.Color.Transparent;
            this.radMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMember.ForeColor = System.Drawing.Color.MistyRose;
            this.radMember.Location = new System.Drawing.Point(127, 543);
            this.radMember.Name = "radMember";
            this.radMember.Size = new System.Drawing.Size(108, 29);
            this.radMember.TabIndex = 2;
            this.radMember.Text = "Member";
            this.radMember.UseVisualStyleBackColor = false;
            this.radMember.CheckedChanged += new System.EventHandler(this.radMember_CheckedChanged);
            // 
            // radGuest
            // 
            this.radGuest.AutoSize = true;
            this.radGuest.BackColor = System.Drawing.Color.Transparent;
            this.radGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGuest.ForeColor = System.Drawing.Color.MistyRose;
            this.radGuest.Location = new System.Drawing.Point(283, 543);
            this.radGuest.Name = "radGuest";
            this.radGuest.Size = new System.Drawing.Size(87, 29);
            this.radGuest.TabIndex = 3;
            this.radGuest.Text = "Guest";
            this.radGuest.UseVisualStyleBackColor = false;
            this.radGuest.CheckedChanged += new System.EventHandler(this.radGuest_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(79, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you a Member or Guest ?";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 794);
            this.Controls.Add(this.radGuest);
            this.Controls.Add(this.radMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(903, 833);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.RadioButton radMember;
        private System.Windows.Forms.RadioButton radGuest;
        private System.Windows.Forms.Label label1;
    }
}

