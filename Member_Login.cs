using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZooManagementSystem
{
    public partial class frmMemberLogin : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZMS_Database.accdb;");
        public frmMemberLogin()
        {
            InitializeComponent();
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTo_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();//creating object of frmMainMenu class
            mainMenu.Show();//Directing user to Main menu when triggered
            this.Hide();
        }

        private void frmMemberLogin_Load(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\Lion_Sleeps_Tonight.wav");//careating an object of library 
            music.Stop();//stops the music when this form loads

            //adding options to combo box
            cmbAdmin.Items.Add("No");//adding no option [0]
            cmbAdmin.Items.Add("Yes");//adding yes option [1]
        }

        private void hrefRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberRegister frmRegister = new frmMemberRegister();//creating object of class frmMemberRegister
            frmRegister.Show();//directing to the register form
            this.Hide();//hides this form
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();//opening the connection the database

                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                cmd.Connection = conn;//establishing connection with database
                cmd.CommandText = "SELECT * FROM members Where email=@email and pwd=@pwd and admin=@admin";

                cmd.Parameters.AddWithValue("@email",txtEmail.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@admin", cmbAdmin.Text);//prevents sql injection

                DataTable dt = new DataTable();//creating a object of class DataTable
                dt.Load(cmd.ExecuteReader());

                conn.Close();//closing the connection to database

                //condition to check if entered items exist
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Member not found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(dt.Rows.Count == 1)
                {
                    if(cmbAdmin.SelectedIndex == 0)
                    {
                        //take member to member menu
                        frmMemberMenu frmMember = new frmMemberMenu();//creating object of class frmMemberMenu
                        frmMember.Show();//directing user to Member menu
                        this.Hide();//hides this form
                    }
                    else if(cmbAdmin.SelectedIndex == 1)
                    {
                        //take member to admin menu
                        frmAdminMenu frmAdmin = new frmAdminMenu();//creating object of class frmAdminMenu
                        frmAdmin.Show();//directing user to admin menu
                        this.Hide();//hides this form
                    }
                    else
                    {
                        MessageBox.Show("Please select a option in the drop down menu!", "Invalid Entry!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = " ";
            txtPwd.Text = " ";
        }

       
    }
}
