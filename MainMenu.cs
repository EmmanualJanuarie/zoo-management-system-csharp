using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\Lion_Sleeps_Tonight.wav");//careating an object of library Sound Player
            music.Play();//plays the sound file  
        }


        private void radMember_CheckedChanged(object sender, EventArgs e)
        {
            frmMemberLogin MemberLogin = new frmMemberLogin(); //creating object of class frmMainMenu
            MemberLogin.Show();//Direct member to Member Login form
            this.Hide();//hides this form
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void radGuest_CheckedChanged(object sender, EventArgs e)
        {
            frmGuestMenu frmGuest = new frmGuestMenu();//creating object of class frmGuestMenu
            frmGuest.Show();//Directing to Guest menu
            this.Hide();//hides this form
        }
    }
}
