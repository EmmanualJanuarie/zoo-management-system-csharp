using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;//connection library
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class frmMemberRegister : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZMS_Database.accdb;");
       
        public frmMemberRegister()
        {
            InitializeComponent();
        }

        private void hrefLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberLogin frmLogin = new frmMemberLogin();//creating object of class frmMemberLogin
            frmLogin.Show();//diecting to the Member login form
            this.Hide();//hides this form
        }

        private void frmMemberRegister_Load(object sender, EventArgs e)
        {
            //GetMemberDetails();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                    conn.Open(); //opening connection to database
                    OleDbCommand cmd = conn.CreateCommand(); //creating instance of OleDbCommand
                    cmd.CommandType = CommandType.Text; //creating the command to handle sql statements

                    cmd.CommandText = "INSERT INTO members (name, email, pwd, admin) VALUES (@name, @email, @pwd, @admin);";
                    cmd.Parameters.AddWithValue("@name", txtName.Text);//prevents sql injection
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);//prevents sql injection
                    cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);//prevents sql injection

                    if (!chkAdmin.Checked)
                        {
                            cmd.Parameters.AddWithValue("@admin", "No");
                        }
                    else
                        {
                        cmd.Parameters.AddWithValue("@admin", "Yes");
                        }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Added data to database!", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clearing textboxes and checkboxes
                    txtName.Text = " ";//cleared textbox for name
                    txtEmail.Text = " ";//cleared textbox for email
                    txtPwd.Text = " ";//cleared textbox for password
                    chkAdmin.Checked = false;//cleared checkbox for Admin

                    conn.Close();//closing the database
                    
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }

            
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

     

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = " ";
            txtPwd.Text = " ";
            txtName.Text = " "; 
            chkAdmin.Checked = false ;
        }
    }
}
