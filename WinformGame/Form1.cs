using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinformGame
{

    public partial class loginPage : Form
    {
       
        OpenFileDialog file = new OpenFileDialog();

        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
           // player = new Player("O:\\vs\\WinformGame\\WinformGame\\Resources\\Picture1.png", "test", new Points(1,2,3));
            //Console.WriteLine(player.username);
            //pictureBox1.Image = Image.FromFile(player.profilePicture);
            
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //file.ShowDialog();
            //PFPPath.Text = file.FileName;
            //Globals.player = new Player(file.FileName, "test", new Points(0, 0, 0));
            //player.SetProfile(file.FileName);
            //pictureBox1.Image = Image.FromFile(Globals.player.profilePicture);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (file.FileName != "" || usernameBox.Text != "")
            {
                this.Hide();
                RPS rpsForm = new RPS();
                rpsForm.Show();
               // Globals.player = new Player("d", "test", new Points(0, 0, 0));
            }
            else
                MessageBox.Show("You have not entered a Username or picked a PFP!");
        }
    }
}
