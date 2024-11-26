using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class frmMemberMenu : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZMS_Database.accdb;");
       
        public void GetCheckupDetails()
        {
            //try-catch
            try
            {
                //declare connection, command and table [used for connection to sql db]
                OleDbConnection conn = new OleDbConnection();//creating a object of class OleDbConnection
                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                DataTable dt = new DataTable();//creating a object of class DataTable

                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZMS_Database.accdb;";

                conn.Open();//opening the connection
                cmd.Connection = conn;//establishing the connection to the database

                cmd.CommandText = "SELECT * FROM checkup;";//Set connection

                dt.Load(cmd.ExecuteReader());//Displays result
                conn.Close();//closing connection
                grvCheckup.DataSource = dt;//Displaying data on datagridview
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());//log error message to the console
                MessageBox.Show(ex.ToString());//Displaying error message to user
            }
        }

        public void GetSelectedAnimal(OleDbCommand cmd)
        {
            if (cmbAnimal.SelectedIndex == 0)
            {
                cmd.Parameters.AddWithValue("@animal", "Zebra");//prevents sql injection
            }
            else if (cmbAnimal.SelectedIndex == 1)
            {
                cmd.Parameters.AddWithValue("@animal", "Elephant");//prevents sql injection
            }
            else if (cmbAnimal.SelectedIndex == 2)
            {
                cmd.Parameters.AddWithValue("@animal", "Lion");//prevents sql injection
            }
            else if (cmbAnimal.SelectedIndex == 3)
            {
                cmd.Parameters.AddWithValue("@animal", "Hyena");//prevents sql injection
            }
            else if (cmbAnimal.SelectedIndex == 4)
            {
                cmd.Parameters.AddWithValue("@animal", "Ape");//prevents sql injection
            }
            else if (cmbAnimal.SelectedIndex == 5)
            {
                cmd.Parameters.AddWithValue("@animal", "Warthog");//prevents sql injection
            }
        }

        public void GetSelectedEncloser(OleDbCommand cmd)
        {
            if (cmbEncloser.SelectedIndex == 0)
            {
                cmd.Parameters.AddWithValue("@encloser", "Carnivore");//prevents sql injection
            }
            else if (cmbEncloser.SelectedIndex == 1)
            {
                cmd.Parameters.AddWithValue("@encloser", "Herbivore");//prevents sql injection
            }
            else if (cmbEncloser.SelectedIndex == 2)
            {
                cmd.Parameters.AddWithValue("@encloser", "Omnivore");//prevents sql injection
            }
        }

        public  void GetSelectedGender(OleDbCommand cmd)
        {
            if (cmbGender.SelectedIndex == 0)
            {
                cmd.Parameters.AddWithValue("@gender", "Male");//prevents sql injection
            }
            else if (cmbGender.SelectedIndex == 1)
            {
                cmd.Parameters.AddWithValue("@gender", "Female");//prevents sql injection
            }
        }
        
        public frmMemberMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMemberLogin frmLogin = new frmMemberLogin();//creating object of class frmMemberLogin
            frmLogin.Show();//logging user out
            this.Hide();//hides this form

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmMemberMenu_Load(object sender, EventArgs e)
        {
            GetCheckupDetails();//calling method [Displaying all the details method in the database]

            //adding options to Animal TYPE combo box
            cmbEncloser.Items.Add("Carnivore");//adding Carnivore option [0]
            cmbEncloser.Items.Add("Herbivore");//adding Herbivore option [1]
            cmbEncloser.Items.Add("Omnivore");//adding Omnivore option [2]

            //adding options to Animal combo box
            cmbAnimal.Items.Add("Zebra");//adding Zebra option [0]
            cmbAnimal.Items.Add("Elephant");//adding Elephant option [1]
            cmbAnimal.Items.Add("Lion");//adding Lion option [2]
            cmbAnimal.Items.Add("Hyena");//adding Hyena option [3]
            cmbAnimal.Items.Add("Ape");//adding Ape option [4]
            cmbAnimal.Items.Add("Warthog");//adding Warthog option [5]

            //adding options to Animal gender combo box
            cmbGender.Items.Add("Male");//adding Carnivore option [0]
            cmbGender.Items.Add("Female");//adding Herbivore option [1]
           

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opening connection to database
                OleDbCommand cmd = conn.CreateCommand(); //creating instance of OleDbCommand
                cmd.CommandType = CommandType.Text; //creating the command to handle sql statements

                cmd.CommandText = "INSERT INTO checkup (animal, encloser, reason, name, age, gender) VALUES (@animal, @encloser, @reason, @name, @age, @gender);";

                GetSelectedAnimal(cmd);//calling method [for the selected animal]
                GetSelectedEncloser(cmd);//calling method [for the selected encloser]

                cmd.Parameters.AddWithValue("@reason", txtReason.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@name", txtName.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@age", txtAge.Text);//prevents sql injection

                GetSelectedGender(cmd);//calling method [for the selected gender]

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Added data to database!", "Access Connect", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                //clearing textboxes and checkboxes
                txtName.Text = " ";//cleared textbox for name
                txtAge.Text = " ";//cleared textbox for age
                txtReason.Text = " ";//cleared textbox for reason
                cmbAnimal.SelectedIndex = -1;//cleared combo box for Animal
                cmbEncloser.SelectedIndex = -1;//cleared combo box for Encloser
                cmbGender.SelectedIndex = -1;//cleared combo box for Gender

                conn.Close();//closing the database
                GetCheckupDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void grvCheckup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = grvCheckup.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();//opening connection to database

                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                cmd.Connection = conn;//establishing the connection to database
                cmd.CommandText = "SELECT * FROM checkup Where id=@id";
                cmd.Parameters.AddWithValue("@id", id);//prevents sql injection

                DataTable dt = new DataTable();//creating a object of class DataTable
                dt.Load(cmd.ExecuteReader());//used when we retrieving or reading data
                conn.Close();//closing connection to database

                if (dt.Rows.Count > 0)
                {
                    lblName.Text = dt.Rows[0]["name"].ToString();
                    lblAge.Text = dt.Rows[0]["age"].ToString();
                    lblGender.Text = dt.Rows[0]["gender"].ToString();
                    lblEncloser.Text = dt.Rows[0]["encloser"].ToString();
                    lblReason.Text = dt.Rows[0]["reason"].ToString();
                }
                else
                {
                    lblName.Text = " ";//clearing name label
                    lblAge.Text = " ";//clearing age label
                    lblGender.Text = " ";//clearing gender label
                    lblEncloser.Text = " ";//clearing encloser label
                    lblReason.Text = " ";//clearing reason label
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var id = grvCheckup.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();//opening connection to database

                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                cmd.Connection = conn;//establishing the connection to database

                cmd.CommandText = "DELETE * FROM checkup Where id=@id";
                cmd.Parameters.AddWithValue("@id", id);//prevents sql injection


                cmd.ExecuteNonQuery();//used when editing or adding data

                conn.Close();//closing connection to database
                GetCheckupDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //clearing textboxes and checkboxes
            txtName.Text = " ";//cleared textbox for name
            txtAge.Text = " ";//cleared textbox for age
            txtReason.Text = " ";//cleared textbox for reason
            cmbAnimal.SelectedIndex = -1;//cleared combo box for Animal
            cmbEncloser.SelectedIndex = -1;//cleared combo box for Encloser
            cmbGender.SelectedIndex = -1;//cleared combo box for Gender
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblName.Text = " ";//clearing name label
            lblAge.Text = " ";//clearing age label
            lblGender.Text = " ";//clearing gender label
            lblEncloser.Text = " ";//clearing encloser label
            lblReason.Text = " ";//clearing reason label
        }
    }
}
