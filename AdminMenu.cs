using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZooManagementSystem
{
    public partial class frmAdminMenu : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZMS_Database.accdb;");
        public void GetMemberDetails()
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

                cmd.CommandText = "SELECT * FROM members;";//Set connection

                dt.Load(cmd.ExecuteReader());//Displays result
                conn.Close();//closing connection
                grvMembers.DataSource = dt;//Displaying data on datagridview
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());//log error message to the console
                MessageBox.Show(ex.ToString());//Displaying error message to user
            }

        }
        public frmAdminMenu()
        {
            InitializeComponent();
            frmMemberRegister frmMember = new frmMemberRegister();  
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMemberLogin frmLogin = new frmMemberLogin();//creating object of class frmMemberLogin
            frmLogin.Show();//logging user out
            this.Hide();//hides this form
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            GetMemberDetails();//calling method from frmMember class
        }

        private void btnInsert_Click(object sender, EventArgs e)
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
                };

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Added data to database!", "Access Connect", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                //clearing textboxes and checkboxes
                txtName.Text = " ";//cleared textbox for name
                txtEmail.Text = " ";//cleared textbox for email
                txtPwd.Text = " ";//cleared textbox for password
                chkAdmin.Checked = false;//cleared checkbox for Admin

                conn.Close();//closing the database
                GetMemberDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var email = grvMembers.CurrentRow.Cells["email"].Value;

                conn.Open();//opening connection to database

                OleDbCommand cmd = conn.CreateCommand(); //creating instance of OleDbCommand
                cmd.Connection = conn;//establishing the connection to database
                cmd.CommandText = "SELECT * FROM members Where email=@email or name=@name";
                cmd.Parameters.AddWithValue("@email", txtSearch.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@name", txtSearch.Text);//prevents sql injection

                DataTable dt = new DataTable();//creating a object of class DataTable
                dt.Load(cmd.ExecuteReader());
                conn.Close();//closing connection to database

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Member not found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dt.Rows.Count == 1)
                {
                    grvMembers.DataSource = dt;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }

        }

        private void grvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = grvMembers.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();//opening connection to database

                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                cmd.Connection = conn;//establishing the connection to database
                cmd.CommandText = "SELECT * FROM members Where id=@id";
                cmd.Parameters.AddWithValue("@id", id);//prevents sql injection

                DataTable dt = new DataTable();//creating a object of class DataTable
                dt.Load(cmd.ExecuteReader());//used when we retrieving or reading data
                conn.Close();//closing connection to database

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    txtPwd.Text = dt.Rows[0]["pwd"].ToString();

                    //creating a string variable for admin entry
                    string admin = dt.Rows[0]["admin"].ToString();
                    if(admin.Equals("Yes"))
                    {
                        chkAdmin.Checked = true;
                    }
                    else
                    {
                        chkAdmin.Checked = false;
                    }
                }
                else
                {
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPwd.Text = "";
                    chkAdmin.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = grvMembers.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();//opening connection to database
                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                cmd.Connection = conn;//establishing the connection to database
                cmd.CommandText = "UPDATE members SET name=@name, email=@email, pwd=@pwd, admin=@admin Where id=@id";

                cmd.Parameters.AddWithValue("@id", id);//prevents sql injection

                cmd.Parameters.AddWithValue("@name", txtName.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);//prevents sql injection
                cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);//prevents sql injection

                if (!chkAdmin.Checked)
                {
                    cmd.Parameters.AddWithValue("@admin", "No");//triggered when checkbox is not checked
                }
                else
                {
                    cmd.Parameters.AddWithValue("@admin", "Yes");//triggered when checkbox is checked
                };


                cmd.ExecuteNonQuery();//used when editing or adding data

                MessageBox.Show("Successfully updated data!", "Access Connect", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                conn.Close();//closing connection to database
                GetMemberDetails();

                //clearing objects
                txtName.Text = " ";//clearing name textbox
                txtEmail.Text = " ";//clearing email textbox
                txtPwd.Text = " ";//clearing password textbox
                chkAdmin.Checked = false;//clearing checkbox 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = " ";//clearing name textbox
            txtEmail.Text = " ";//clearing email textbox
            txtPwd.Text = " ";//clearing password textbox
            chkAdmin.Checked = false;//clearing checkbox 
            txtSearch.Text = " ";//clearing search textbox
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = grvMembers.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();//opening connection to database

                OleDbCommand cmd = new OleDbCommand();//creating a object of class OleDbCommand
                cmd.Connection = conn;//establishing the connection to database

                cmd.CommandText = "DELETE * FROM members Where id=@id";
                cmd.Parameters.AddWithValue("@id", id);//prevents sql injection


                cmd.ExecuteNonQuery();//used when editing or adding data

                conn.Close();//closing connection to database
                GetMemberDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();//closing the database
            }
        }
    }
}
